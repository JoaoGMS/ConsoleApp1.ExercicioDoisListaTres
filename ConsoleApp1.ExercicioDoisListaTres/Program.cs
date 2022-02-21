using System;

namespace ConsoleApp1.ExercicioDoisListaTres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                    Console.WriteLine(i + " é impar");
            }
        }
    }
}
