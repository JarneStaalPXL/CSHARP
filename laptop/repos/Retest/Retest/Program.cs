using System;

namespace Retest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(num1, num2);
            Console.WriteLine("Biggest number is " + max);
        }
    }
}
