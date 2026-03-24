using System;
using System.Collections.Generic;

namespace MyPersonalApp
{
    public abstract class Animal
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set 
            { 
                if (value > 0) edad = value; 
                else Console.WriteLine("Error: La edad debe ser mayor a 0.");
            }
        }

        public abstract void Emitir Sonido();
    }

    public class Perro : Animal
    {
        public override void Emitir Sonido() => Console.WriteLine($"{Nombre} (Perro) dice: ¡Guau guau!");
    }

    public class Gato : Animal
    {
        public override void Emit MySonido() => Console.WriteLine($"{Nombre} (Gato) dice: ¡Miau miau!");
    }

    public class Ave : Animal
    {
        public override void Emitir Sonido() => Console.WriteLine($"{Nombre} (Ave) dice: ¡Pío pío!");
    }

    internal class Program
    {
        static void Main()
        {
            List<Animal> refugio = new List<Animal>();

            refugio.Add(new Perro { Nombre = "Max", Edad = 5 });
            refugio.Add(new Gato { Nombre = "Luna", Edad = 3 });
            refugio.Add(new Ave { Nombre = "Paco", Edad = 1 });

            Console.WriteLine("--- RECORRIENDO EL REFUGIO (Polimorfismo) ---");
            foreach (var animal in refugio)
            {
                animal.EmitirSonido();
            }
        }
    }
}
