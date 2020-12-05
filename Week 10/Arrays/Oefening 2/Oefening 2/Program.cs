using System;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //gevaarlijk XD
            {
                Console.WriteLine("\nEnter size of array");
                IsLangerDanTien();
            }

        }

        private static void IsLangerDanTien()
        {
            int input = int.Parse(Console.ReadLine());
            int[] TienGetallen = new int[input];

            if (TienGetallen.Length > 10)
            {
                Console.WriteLine($"De Array is groter dan 10. Hij bevat {input} waardes");

            }
            else
            {
                Console.WriteLine($"De Array is kleiner dan 10. Hij bevat {input} waardes");
            }
        }
    }
}
