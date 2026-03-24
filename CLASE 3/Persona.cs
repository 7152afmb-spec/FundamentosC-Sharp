using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPersonalApp
{
    public abstract class Persona
    {
        private string Nombre;

        public int Edad { get; set; }

        public Persona() 
        {
            this.Nombre = "Juan";
        }
        public Persona(string nombre, int edad) 
        {
            this.Nombre = nombre;
            this.Edad = edad;
        }

        public void SetNombre(string nuevoNombre)
        {
            this.Nombre = nuevoNombre;
        }
        public string GetNombre() 
        {
            return this.Nombre;
        }

        public abstract void MostrarInfo();

        public virtual decimal CalcularPago() 
        { 
            return 1000;
        }
    }
}