using System;
using System.Collections.Generic;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> intlist = new List<int>();

                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    intlist.Add(random.Next(1, 20));
                }

                Console.WriteLine(" This is the list");
                for (int i = 0; i < intlist.Count; i++)
                {
                    Console.Write("  " + intlist[i]);
                }
                Console.WriteLine($"\n\n  The max is {Max(intlist)}");

                Console.WriteLine("\n PRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        private static int Max(List<int> intlist)
        {
            int maximum = int.MinValue;

            foreach (var item in intlist)
            {
                if (maximum < item)
                {
                    maximum = item;
                }
            }
            return maximum;
        }
    }
}
