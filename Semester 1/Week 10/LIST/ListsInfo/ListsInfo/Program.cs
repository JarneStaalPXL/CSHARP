using System;
using System.Collections.Generic;

namespace ListsInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };


            List<int> intlist;
            intlist = new List<int>(array); 
            List<int> inttweedelist = new List<int>() { 1, 2, 3, 4, 5, 6, 9001 };
            List<int> intDerdeList = new List<int>(inttweedelist);

            intlist[0] = 0;
            int a = intlist[1];

            //intlist.Insert(2, 901);
            Print(intlist);

            if (intlist.Contains(9000))
            {
                Console.WriteLine("9001 is aanwezig in de lijst");
                Console.WriteLine($"het element zit op de {inttweedelist.IndexOf(9001)}");
            }

            intlist.Remove(2);
            Print(intlist);
            intlist.RemoveAt(1);
            Print(intlist);

            intlist.Clear();
            Console.WriteLine(intlist.Count);
        }

        private static void Print(List<int>list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(" "+list[i]);
            }
            Console.WriteLine();
        }
    }
}
