using System;

namespace Oefening_5
{
    class Program
    {
        private int Macht(int grondtal, int exponent, int resultaat)
        {
            for (int i = 0; i <= exponent; i++)
            {
                resultaat = exponent * grondtal;
            }
            return resultaat;
        }

        static void Main(string[] args)
        {
            Console.Write("Geef grondtal in: ");
            int grondtal = int.Parse(Console.ReadLine());
            Console.Write("Geef exponent in: ");
            int exponent = int.Parse(Console.ReadLine());

            int resultaat = 0;

            Console.WriteLine(resultaat);
        }
    }
}
