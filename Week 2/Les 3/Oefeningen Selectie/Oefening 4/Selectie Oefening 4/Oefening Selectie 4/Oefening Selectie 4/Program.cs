using System;

namespace Oefening_Selectie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een klinker of medeklinker");
            string input = Console.ReadLine();

            if ("aeiouAEIOU".Contains(input))
            {
                Console.WriteLine(input + "  is een klinker.");
            }
            else
                Console.WriteLine(input + "  is een medeklinker");
        }
	}
}
    