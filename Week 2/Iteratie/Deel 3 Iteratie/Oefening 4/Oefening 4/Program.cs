using System;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 4: Schrijf een programma dat een rechthoekige driehoek van oplopende getallen");
            Console.WriteLine("afdrukt van een gegeven aantal rijen.");
            Console.WriteLine();


            int heightTriangle;
            while (true)
            {
                Console.WriteLine("Input hoogte driehoek");
                if (int.TryParse(Console.ReadLine(), out heightTriangle))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
            }

            Console.WriteLine();
            int count = 1;
            for (int i = 1; i <= heightTriangle; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(count++);
                }
                Console.WriteLine();
            }

        }
    }
}
