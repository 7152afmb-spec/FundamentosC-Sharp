using System;

namespace MyPersonalApp;
class Program
{
      static void Main()
    {
        for (int i = 1; i <= 50; i++)
        {
            if (i == 25)
            {
                break; 
            }
             Console.WriteLine(i);
        }

        for (int i = 26; i <= 50; i++)
        {
            if (i % 5 == 0)
            {
                continue; 
            }

            Console.WriteLine(i);
        }
    }
}