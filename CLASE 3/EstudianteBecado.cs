using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyPersonalApp
{
    public class EstudianteBecado : Estudiante
    {
        public string TipoBeca { get; set; }

        public EstudianteBecado(string nombre, int edad, string carrera, string tipoBeca)
            : base(nombre, edad, carrera)
        {
            TipoBeca = tipoBeca;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {Edad}, Carrera: {this.GetCarrera}, Beca: {TipoBeca}");
        }
        public override decimal CalcularPago() 
        { 
            decimal pagoBase = base.CalcularPago();
            return pagoBase * 0.5m; 
        }
    }
}