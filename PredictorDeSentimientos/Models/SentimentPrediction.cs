using Microsoft.ML.Data;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace predictor_de_sentimientos.Models
{
    public class SentimientosPrediction
    {
       [ColumnName("PredictionLabel")]
        public bool Prediction { get; set; }
        public float Probability { get; set; }//0 = negativo, 1 = positivo
        public float Score { get; set; }
    }
}