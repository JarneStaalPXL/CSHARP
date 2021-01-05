using System;

namespace for_loops_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aantal Rijen hoog?");
            int height = int.Parse(Console.ReadLine());
            string square = "";

            for (int i = 1; i <=height; i++)  //This for loop will make the first row of X's//
            {
                square += "X";   //square is input * X //        
            }
            for (int i = 1; i <=height; i++)  //This for loop will create the rest of the rows of X's//
            {
                Console.WriteLine(square);
            }
        }
    }
}
