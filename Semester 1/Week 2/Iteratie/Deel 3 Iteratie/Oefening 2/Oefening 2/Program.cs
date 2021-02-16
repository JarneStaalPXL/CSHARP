using System;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 2: Schrijf een programma dat het woord Hallo schrijft en iedere keer een letter minder toont.");

            string hallo = "Hallo";
            for (int i = 0; i < hallo.Length; i++)
            {
                Console.WriteLine(hallo.Substring(0, hallo.Length - i));
            }

            Console.ReadLine();
        }
    }
}
