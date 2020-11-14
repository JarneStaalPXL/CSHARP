using System;

namespace Oefening_4
{
    class Program
    {

        private static int IsBiggerThanHundred(int a, int b, int c)
        {

            int sum = a+b+c;
            return sum;
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Enter number");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int c = int.Parse(Console.ReadLine());


            if (IsBiggerThanHundred(a,b,c) > 100)
            {
                Console.WriteLine("the sum is higher than 100");
            }
            else
            {
                Console.WriteLine("the sum is lower than 100");
            }
        }
    }
}
