using System;
using System.Collections.Generic;

namespace MyPersonalApp
{
    internal class Program
    {
        static void Main(string [] args)
        {
            List <string> nombres = new List<string> () { "Luisa", "Julia", "Ana", "Susie" };
            foreach (string nombre in nombres)
            {
                if (nombre == "Ana")
                {
                    Console.WriteLine("Ana se enfermo, no la podemos saludar");
                    continue;
                }
                Console.WriteLine($"Hola {nombre}, que tal?");
            }
        }
    }
}