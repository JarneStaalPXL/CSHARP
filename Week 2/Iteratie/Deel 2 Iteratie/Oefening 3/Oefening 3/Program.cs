using System;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 3:  leeg vierkant afdrukken van een gegeven zijde lengte");

            Console.WriteLine("Input number?");
            int side = Convert.ToInt32(Console.ReadLine());

            int countLayer = 1;

            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    // i == 0 is top layer || j == 0 is left side || i == width - 1 is bottom layer || j == width - 1 is right side
                    // j == width - 1
                    if (i == 0 || j == 0 || i == side - 1 || j == side - 1)
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
