using System;
using System.Collections.Generic;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listVanInts = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            Console.WriteLine(String.Join(" ", RandomSet(5, listVanInts)));
        }

        private static List<int> RandomSet(int grootteSubset, List<int> oorspronkelijkeList)
        {
            List<int> kopieList = new List<int>(oorspronkelijkeList);

            List<int> subset = new List<int>();
            Random random = new Random();

            for (int i = 0; i < grootteSubset; i++)
            {
                int randomItem = kopieList[random.Next(kopieList.Count)];
                kopieList.Remove(randomItem);
                subset.Add(randomItem);
            }
            return subset;
        }
    }
}
