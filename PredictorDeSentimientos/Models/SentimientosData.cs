using Microsoft.ML.Data;
using System;

namespace predictor_de_sentimientos.Models
{
    public class SentimientosData
    {
        [LoadColumn(0)]
        public float Label { get; set; }//0 = negativo, 1 = positivo
        
        [LoadColumn(5)]
        public string Text { get; set; } //El texto o la frase q se va a analizar
    }
}