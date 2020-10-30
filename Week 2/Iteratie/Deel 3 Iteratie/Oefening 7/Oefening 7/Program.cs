using System;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Oefening 7: Schrijf een programma dat een vierkant afdrukt" +
                        " met alternerende x’en en o’s van een gegeven aantal rijen.Iedere even " +
                        "rij start met een ‘o’ en elke oneven rij start met een ‘x’. ");

                Console.WriteLine("Aantal rijen in vierkant");
                int sqrRows = int.Parse(Console.ReadLine());
            

            for (int row = 1; row <= sqrRows; row++)
            {
                for (int col = 1; col <= sqrRows; col++)
                {
                    if (row % 2 == 0)
                    {
                        //even row
                        if (col % 2 == 0)
                        {
                            //even column
                            Console.Write("x");

                        }
                        else
                        {
                            //odd column
                            Console.Write("o");
                        }
                    }
                    else
                    {
                        //odd row
                        if (col % 2 == 0)
                        {
                            //even column
                            Console.Write("o");
                        }
                        else
                        {
                            //odd column
                            Console.Write("x");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
