using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.DM
{
    
    public class Cluster
    {
        public static void Entrenar()
        {
            var dataLocation = "./DatosWeka.csv";
            var context = new MLContext();
            var textLoader = context.Data.CreateTextLoader(new[]
            {
                new TextLoader.Column("id",DataKind.Single,0),
                new TextLoader.Column("pmat",DataKind.Single,1),
                new TextLoader.Column("pcom",DataKind.Single,2),
                new TextLoader.Column("ecemat",DataKind.Single,3),
                new TextLoader.Column("ececom",DataKind.Single,4),
                new TextLoader.Column("cdocmat",DataKind.Single,5),
                new TextLoader.Column("cdotcom",DataKind.Single,6),
                new TextLoader.Column("Label", DataKind.Single,7)

            },
            hasHeader : true,
            separatorChar: ',');

            var data = textLoader.Load(dataLocation);

            var testTrainData = context.Data.TrainTestSplit(data, testFraction: 0.2);

            var pipeline = context.Transforms.Concatenate("Features", "id", "pmat", "pcom", "ecemat", "ececom", "cdocmat", "cdotcom")
                .Append(context.Clustering.Trainers.KMeans(featureColumnName: "Features", numberOfClusters: 2));

            var model = pipeline.Fit(testTrainData.TrainSet);
            var predictions = model.Transform(testTrainData.TestSet);

            var metrics = context.Clustering.Evaluate(predictions, scoreColumnName: "Score", featureColumnName: "Features");

            Console.WriteLine($"Average minimum score: {metrics.AverageDistance}");

            //TODO implementar motor de predicción con el modelo

        }
    }
}
