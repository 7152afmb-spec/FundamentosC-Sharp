using System;

namespace MyPersonalApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            int opcion;
            
            do
            {
                Console.WriteLine("Ingresa un número positivo");
                opcion = int.Parse(Console.ReadLine());
                
            } while (opcion <= 0);

            Console.WriteLine("Tu numero es:" + opcion);
        }
    }
}