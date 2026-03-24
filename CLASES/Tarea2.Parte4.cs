using System;

namespace MyPersonalApp
{
    class Program
    {
        static void Main()
        {
            string opcion;

            do
            {
                Console.WriteLine("\n--- MENÚ INTERACTIVO ---");
                Console.WriteLine("a. Mostrar números pares (1-20)");
                Console.WriteLine("b. Mostrar números impares (1-20)");
                Console.WriteLine("c. Salir");
                Console.Write("Seleccione una opción: ");
            
                opcion = Console.ReadLine().ToLower();

                switch (opcion)
                {
                    case "a":
                        Console.WriteLine("\nNúmeros pares:");
                        for (int i = 1; i <= 20; i++)
                        {
                            if (i % 2 == 0) Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;

                    case "b":
                        Console.WriteLine("\nNúmeros impares:");
                        for (int i = 1; i <= 20; i++)
                        {
                            if (i % 2 != 0) Console.Write(i + " ");
                        }
                        Console.WriteLine();
                        break;

                    case "c":
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

            } while (opcion != "c");
        }
    }
}