using System;

namespace MyPersonalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Hola, porfavor ingresa tu nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola, {nombre},por favor indicanos tu edad");
            string edad = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}, tienes {edad} años");
        }
    }
}