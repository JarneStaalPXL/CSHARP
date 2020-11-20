using System;

namespace Oefening_4
{
    class Program
    {

        private static bool IsBiggerThanHundred(int a, int b, int c)
        {

            int sum = a+b+c;

            if (sum > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int c = int.Parse(Console.ReadLine());

            if (IsBiggerThanHundred(a,b,c))
            {
                Console.WriteLine("Het is groter dan 100");
            }
            else
            {
                Console.WriteLine("Het is kleiner dan 100");
            }

        }
    }
}
