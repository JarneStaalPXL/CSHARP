using System;
using System.Linq;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] array = new int[10];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                array[i] = random.Next(1, 12);
                Console.Write($" {array[i]}");
                }

            
                Console.WriteLine($"\nThe average is " + AvgArray(array));
                //Console.WriteLine($"\nThe average is " + array.Average()); 
                

                Console.WriteLine("\nPRESS ENTER TO REPEAT");
                string answer = Console.ReadLine();
                
                Console.Clear();
            }
            

        }

        private static double AvgArray(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double result = sum / (double)array.Length;

            return result;
        }
    }
}
