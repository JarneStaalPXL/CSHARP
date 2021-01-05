using System;

namespace FOR_LOOP_TRIANGLE
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp = 1; //temporal number
            Console.WriteLine("Aantal rijen hoog");
            int input = Convert.ToInt32(Console.ReadLine());  //Input is amount of rows
            Console.Clear();

            for (int rows = 1; rows <=input ; rows++)
            {
                for (int col = 1; col<=rows; col++)
                {
                    Console.Write("X ");
                    //Console.Write($"{input} ");
                    //input--;
                }
                Console.WriteLine();
            }
        }
    }
}
