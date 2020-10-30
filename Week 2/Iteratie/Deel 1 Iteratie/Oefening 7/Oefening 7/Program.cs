using System;
using System.Collections.Generic;
using System.Linq;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isNietNul = true;
            List<int> lijst = new List<int>();
            while (isNietNul)
            {
                Console.WriteLine("Geef een getal in als het nul is stopt het programma");
                int nr1 = Convert.ToInt32(Console.ReadLine());
                if (nr1 != 0)
                {
                    lijst.Add(nr1);
                }
                else
                {
                    int hoogste = lijst.Max();
                    int laagste = lijst.Min();
                    Console.WriteLine($"Je gaf een 0 in, je hoogste cijfer was {hoogste} en je laagste cijfer was {laagste}");
                    isNietNul = false;

                }
            }
        }
    }
}
