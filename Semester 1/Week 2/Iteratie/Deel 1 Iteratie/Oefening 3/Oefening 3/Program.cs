using System;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i+=2)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
