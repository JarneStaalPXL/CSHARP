using System;

namespace _2D_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array2D = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                        { "five", "six" } };



            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(" "+ array2D[i, j]);
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
