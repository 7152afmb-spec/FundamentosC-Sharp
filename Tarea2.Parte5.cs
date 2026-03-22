using System;
using System.Text.RegularExpressions;

namespace MyPersonalApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese su edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine($"Edad válida: {edad} años.");
            }
            else
            {
                Console.WriteLine("Error: La edad debe ser un número entero.");
            }

            Console.Write("Ingrese su correo electrónico: ");
            string correo = Console.ReadLine();
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (Regex.IsMatch(correo, patronCorreo))
            {
                Console.WriteLine("Correo electrónico válido.");
            }
            else
            {
                Console.WriteLine("Error: El formato del correo no es válido.");
            }
        }
    }
}
