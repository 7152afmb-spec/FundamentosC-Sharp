using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalApp
{
    public class Estudiante : Persona
    {
        private string Carrera;
        public void SetCarrera(string nuevaCarrera)
        {
            this.Carrera = nuevaCarrera;
        }
        public string GetCarrera()
        {
            return this.Carrera;
        }
        public Estudiante(string nombre, int edad, string carrera) : base()
        {
            this.Carrera = carrera;
        }
        public override void MostrarInfo()
        {
            Console.WriteLine($"Estudiante: {this.GetNombre()}, Edad: {this.Edad}, Carrera: {this.Carrera}");
        }
        public override decimal CalcularPago() 
        { 
            if (Carrera == "Medicina") 
                return 2000; 
            if (Carrera == "Ingeniería") 
                return 1500; 
            return 1200; 
        }
    }
}