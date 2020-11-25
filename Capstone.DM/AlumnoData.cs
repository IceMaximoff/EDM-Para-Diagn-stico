using Microsoft.ML.Data;

namespace Capstone.DM
{
    public class AlumnoData
    {
        [LoadColumn(0)]
        public float id;
        [LoadColumn(1)]
        public float pmat;
        [LoadColumn(2)]
        public float pcom;
        [LoadColumn(3)]
        public float ecemat;
        [LoadColumn(4)]
        public float ececom;
        [LoadColumn(5)]
        public float cdocmat;
        [LoadColumn(6)]
        public float cdotcom;
    }

    public class ClusterPrediction
    {
        [ColumnName("PredictedLabel")]
        public uint PredictedClusterId;

        [ColumnName("Score")]
        public float[] Distances;
    }
}
