using System;

namespace Oefening_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aantal rijen hoog?");
            int heightTriangle = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= heightTriangle; i++)
            {
                string baseTriangle = "";
                for (int b = 1; b <= i; b++)
                {
                    baseTriangle += "x";
                }
                Console.WriteLine(baseTriangle);
            }
        }
    }
}
