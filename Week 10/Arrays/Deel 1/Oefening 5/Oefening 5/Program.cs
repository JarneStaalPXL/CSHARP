using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arraywithnumbers = new int[4];
            arraywithnumbers[0] = 500;
            arraywithnumbers[1] = 800;
            arraywithnumbers[2] = 300;
            arraywithnumbers[3] = 1000;

            //Optional if you want to use input
            /*
             
            Console.WriteLine("Enter 4 numbers");

            for (int i = 0; i < arraywithnumbers.Length; i++)
            {
                arraywithnumbers[i] = int.Parse(Console.ReadLine());
            }
            
            */

            Console.WriteLine($"The Minimum Is:  " + MinArray(arraywithnumbers));
            Console.WriteLine($"The Maximum Is:  " + MaxArray(arraywithnumbers));
        }

        private static int MinArray(int[] arraywithnumbers)  //Returns minimum value of given array
        {
            int min = arraywithnumbers[0];

            for (int i = 0; i < arraywithnumbers.Length; i++)
            {
                if (arraywithnumbers[i] < min)
                {
                    min = arraywithnumbers[i];
                    
                }
            }
            return min;
        }

        private static int MaxArray(int[] arraywithnumbers) //Returns maximum value of given array
        {
            int max = arraywithnumbers[0];
            for (int i = 0; i < arraywithnumbers.Length; i++)
            {
                if (arraywithnumbers[i] > max)
                {
                    max = arraywithnumbers[i];
                }
            }
            return max;
        }
    }
}
