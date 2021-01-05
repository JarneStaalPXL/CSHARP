using System;

namespace FOR_LOOP_PYRAMID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input num?");
            int input = Convert.ToInt32(Console.ReadLine());

            string square = "";

            for (int i = 0; i <= input; i++)
            {
                square += input;
            }
            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(square);
            }
        }
    }
}
