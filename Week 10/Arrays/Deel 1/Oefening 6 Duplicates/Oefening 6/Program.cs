using System;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rij = new int[] { 0, 1, 1, 2, 3, 3, 4, 5, 6, 7, 9, 9, 10, 11, 10 };
            Console.WriteLine(CountDuplicates(rij).ToString());
        }

        private static int CountDuplicates(int[] rij)
        {
            
            bool[] isChecked = new bool[rij.Length];
            int countDuplicates = 0;

            for (int i = 0; i < rij.Length; i++)
            {
                for (int j = 0; j < rij.Length; j++)
                {
                    if (rij[i]  == rij[j])
                    {
                        if (isChecked[i])
                        {
                            countDuplicates++;
                        }
                        isChecked[i] = true;
                        isChecked[j] = true;
                    }
                }
            }
            return countDuplicates;
        }
    }
}
