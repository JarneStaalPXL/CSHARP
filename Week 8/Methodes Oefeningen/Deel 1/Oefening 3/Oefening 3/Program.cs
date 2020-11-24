using System;

namespace Oefening_3
{
    class Program
    {
        private static string Oefening3Karakter(int a)
        {

            if (a % 2 == 0)
            {
                return "#";
            }
            else
            {
                return "%";
            }
        }

        static void Main(string[] args)
        {
            // Oefening 3
            for (int i = 0; i <= 5; i++)
            {
                for (int j = 0; j <= 5; j++)
                {
                    // TODO krijg een getal
                    Random randomizer = new Random();
                    Console.Write(Oefening3Karakter(randomizer.Next()));
                }
                Console.WriteLine();
            }
        }
    }
}
