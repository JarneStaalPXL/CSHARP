using System;
using System.Linq;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rij = RandomTien();
            for (int i = 0; i < rij.Length; i++)
            {
                Console.Write($"  { rij[i]}");
            }

            /*Alternatief
            Console.WriteLine(String.Join(" ", rij));*/
        }

        private static int[] RandomTien()
        {
            int[] tiengetallen = new int[10];

            //Oefening 3
            Random random = new Random();
            for (int i = 0; i < tiengetallen.Length; i++)
            {
                tiengetallen[i] = random.Next(1, 11);
            }
            return tiengetallen;
        }
    }
}