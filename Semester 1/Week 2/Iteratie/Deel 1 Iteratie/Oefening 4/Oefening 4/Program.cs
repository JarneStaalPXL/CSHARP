    using System;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input num?");
            double input2 = Convert.ToInt32(Console.ReadLine());
            double result = input2;
            for (double i = input2 -1; i >= 1; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
    }
}