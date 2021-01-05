using System;

namespace ConsoleApp5
{
    class Program
    {
        private static int IsBiggerThanHundred(int a, int b, int c)
        {

            int sum = a + b + c;
            return sum;
        }

        static void Main(string[] args)

        {

            

            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());

            string[] numbers = new string[input];

            for (int i = 0; i < length; i++)
            {

            }
            


            if (IsBiggerThanHundred(a, b, c) > 100)
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
