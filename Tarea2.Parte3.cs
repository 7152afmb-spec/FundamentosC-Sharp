using System;

namespace MyPersonalApp
{
    class Program
    {
        static void Main()
        {
            int numero = -1;
            Console.WriteLine("Ingresa números positivos (0 para salir, >100 para interrumpir):");

            while (numero != 0)
            {
                Console.Write("Introduce un número: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > 100)
                    {
                        Console.WriteLine("Número mayor a 100 detectado. Terminando programa con break...");
                        break; 
                    }
                
                    if (numero < 0)
                    {
                        Console.WriteLine("Por favor, ingresa solo números positivos.");
                    }
                    else if (numero != 0)
                    {
                        Console.WriteLine($"Has ingresado: {numero}");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingresa un número.");
                }
            }

            Console.WriteLine("Ciclo finalizado.");
        }
    }
}