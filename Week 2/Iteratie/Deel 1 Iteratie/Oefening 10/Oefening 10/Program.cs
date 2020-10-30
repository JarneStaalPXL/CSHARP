using System;

namespace Oefening_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoogte vierkant?");
            int height = Convert.ToInt32(Console.ReadLine());
            string baseSquare = "";
            for (int i = 1; i <= height; i++)
            {
                baseSquare += "X";
            }
            for (int i = 1; i <= height; i++)
            {
                Console.WriteLine(baseSquare);
            }
        }
    }
}
