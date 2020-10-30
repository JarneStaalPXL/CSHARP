using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 4: vierkant afdrukken van een gegeven zijde lengte met de diagonalen.");

            Console.WriteLine("Input number?");
            int width = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    //making the square:
                    //i == 0 is top layer || j == 0 is left side || i == width - 1 is bottom layer || j == width - 1 is right side
                    //making the diagonals: 
                    //i == j is the diagonal from the left || i + j == width - 1 is the diagonal from the right
                    if (i == 0 || j == 0 || i == width - 1 || j == width - 1 || i == j || i + j == width - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
