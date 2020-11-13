using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number 1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter number 2 ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Enter number 3 ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Clear();


            int max = Math.Max(num3, Math.Max(num1, num2));

            Console.WriteLine($"The max is " + max);
        }
    }
}
