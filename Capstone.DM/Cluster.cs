using Capstone.Core.DTOs;
using Microsoft.ML;
using System;
using System.IO;

namespace Capstone.DM
{

    public class Cluster
    {
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "modeloRiesgo.model");
        static readonly string _dataPath = Path.Combine(Environment.CurrentDirectory, "DatosWeka.csv");

        public static DiagnosticoDto Diagnosticar(AlumnoDataDto alumnoDataDto)
        {
            #region protoent
            /*
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
            */
            //TODO implementar motor de predicción con el modelo
            #endregion protoent

            var mlContext = new MLContext(seed: 0);
            IDataView dataView = mlContext.Data.LoadFromTextFile<AlumnoData>(_dataPath, hasHeader: false, separatorChar: ',');
            string featuresColumnName = "Features";
            var pipeline = mlContext.Transforms
                .Concatenate(featuresColumnName, "id", "pmat", "pcom", "ecemat", "ececom", "cdocmat", "cdotcom")
                .Append(mlContext.Clustering.Trainers.KMeans(featuresColumnName, numberOfClusters: 2));
            var model = pipeline.Fit(dataView);
            using (var fileStream = new FileStream(_modelPath, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                mlContext.Model.Save(model, dataView.Schema, fileStream);
            }
            var predictor = mlContext.Model.CreatePredictionEngine<AlumnoData, ClusterPrediction>(model);
            var alumno = new AlumnoData
            {
                id = 1f,
                pmat = (float)alumnoDataDto.math.grade,
                pcom = (float)alumnoDataDto.language.grade,
                ecemat = (float)alumnoDataDto.math.ece,
                ececom = (float)alumnoDataDto.language.ece,
                cdocmat = (float)alumnoDataDto.math.teacherPoints,
                cdotcom = (float)alumnoDataDto.language.teacherPoints

            };
            var prediction = predictor.Predict(alumno);
            Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
            int predictedClusterId = (int)prediction.PredictedClusterId;
            Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances)}");
            /*
            DataViewSchema modelSchema;
            ITransformer trainedModel = mlContext.Model.Load(_modelPath, out modelSchema);
         

            var predictor = mlContext.Model.CreatePredictionEngine<AlumnoData, ClusterPrediction>(trainedModel);
            */
            /*
            var alumno = new AlumnoData
            {
                id = 1f,
                pmat = (float)alumnoDataDto.math.grade,
                pcom = (float)alumnoDataDto.language.grade,
                ecemat = (float)alumnoDataDto.math.ece,
                ececom= (float)alumnoDataDto.language.ece,
                cdocmat= (float)alumnoDataDto.math.teacherPoints,
                cdotcom= (float)alumnoDataDto.language.teacherPoints
                
            };*/
            /*
            var prediction = predictor.Predict(alumno);
            Console.WriteLine($"Cluster: {prediction.PredictedClusterId}");
            Console.WriteLine($"Distances: {string.Join(" ", prediction.Distances)}");
            */
            var diagnosticoDto = new DiagnosticoDto
            {
                //id = predictedClusterId.ToString(),
                id = alumnoDataDto.id,
                name = alumnoDataDto.name,
                age = alumnoDataDto.age,
                atRisk = (predictedClusterId==1) ? false:true

            };
            return diagnosticoDto;
        }
    }
}
