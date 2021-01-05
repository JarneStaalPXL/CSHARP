using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine($"{i}² = {Math.Pow(i, 2)}");
            }
        }
    }
}