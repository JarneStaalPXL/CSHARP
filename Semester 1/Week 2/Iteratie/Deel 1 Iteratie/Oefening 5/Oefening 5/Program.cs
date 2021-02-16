using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input num?");
            int getal = int.Parse(Console.ReadLine());

            for (int i = 1; i <=getal; i++)
            {
                Console.WriteLine($"{i}² = { Math.Pow(i, 2)}"); 
            }
        }
    }
}
