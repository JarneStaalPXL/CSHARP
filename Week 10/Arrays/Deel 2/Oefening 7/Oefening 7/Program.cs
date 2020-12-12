using System;
using System.Linq;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                int[] array = new int[5];
                Random random = new Random();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 20);
                    Console.Write(" " + array[i]);
                }
                Console.WriteLine(array.Min());

                Console.ReadLine();
            }
            
        }

        //private static int Minimum(int[] array, int result)
        //{
        //    int min = array[0];

        //    for (int i = 1; i < array.Length; i++)
        //    {
        //        if (array[i] < min)
        //        {
        //            min = array[i];
        //        }
        //    }
        //    return result;
        //}
    }
}
