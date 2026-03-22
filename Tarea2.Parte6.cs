using System;
using System.Security.Cryptography;
using System.Text;

namespace MyPersonalApp
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese una nueva contraseña: ");
            string passwordOriginal = Console.ReadLine();

            byte[] saltBytes = new byte[16];
            RandomNumberGenerator.Fill(saltBytes);
            string salt = Convert.ToBase64String(saltBytes);

            string hashGenerado = GenerarHash(passwordOriginal, salt);

            Console.WriteLine($"\nPassword Original: {passwordOriginal}");
            Console.WriteLine($"Salt generado: {salt}");
            Console.WriteLine($"Hash SHA-256: {hashGenerado}");
        }

        static string GenerarHash(string password, string salt)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] combinedBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(combinedBytes);
                return Convert.ToHexString(hashBytes);
            }
        }
    }
}