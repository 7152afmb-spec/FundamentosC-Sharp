using System;

namespace MypersonalApp
{
    internal class Program
    {
        static void Main()
        {
            string usuarioInput = "admin";
            string passwordInput = "12345";

            string querySegura = "SELECT * FROM Usuarios WHERE Username = @usuario AND Password = @password";

            Console.WriteLine("Consulta generada (simulada):");
            Console.WriteLine(querySegura);
            Console.WriteLine($"Parámetros enviados: @usuario='{usuarioInput}', @password='{passwordInput}'");
        }
    }
}