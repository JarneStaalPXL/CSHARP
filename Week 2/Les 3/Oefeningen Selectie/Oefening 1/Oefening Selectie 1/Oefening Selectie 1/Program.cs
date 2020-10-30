using System;

namespace Oefening_Selectie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Getal 1:   ");
            int getal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Getal 2:   ");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Getal 3:   ");
            int getal3 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(getal1, Math.Max(getal2, getal3));
            Console.WriteLine("Grootste getal:  " + max);
        }
    }
}
