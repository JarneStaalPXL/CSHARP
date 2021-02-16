using System;
using System.Collections.Generic;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> intlist = new List<int>();
                int getal = 1;

                Random random = new Random();
                for (int i = 0; i < 50; i++)
                {
                    intlist.Add(random.Next(1, 10));
                }

                Console.WriteLine(" The list contains ");
                foreach (int item in intlist)
                {
                    Console.Write(" " + item);
                }

                Console.WriteLine($"\nDuplicates:  " + CountElement(intlist, getal));

                Console.WriteLine("\n\nPRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static int CountElement(List<int> intlist, int getal)
        {
            int teller = 0;

            foreach (int item in intlist)
            {
                if (item == getal)
                {
                    teller++;
                }
            }
            return teller;
        }
    }
}
