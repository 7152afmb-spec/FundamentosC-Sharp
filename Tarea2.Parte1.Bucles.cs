using System;

namespace MyPersonalApp
{
    internal class Program
    {
        static void Main (string [] args)
        {
            for (int i = 1; i < 50; i++)
            {
                if (i == 25)
                {
                    Console.WriteLine("Llegamos a 25");
                    break;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Saltando número multiplo de 5");
                    continue;
                }
                Console.WriteLine($"Número: {i}");
            }
        }
    }
}