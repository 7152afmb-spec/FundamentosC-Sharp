using System;

namespace Myapp

{
    internal class Program
    {
        static void Main(string [] args)
{
    int [] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    foreach(int numero in numeros)
    {
        Console.WriteLine(numero);
    }

    while (true){
        Console.WriteLine("Hola");
        break;
        }
}
    }
}