using System;
using System.Collections.Generic;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input number");
                int input = int.Parse(Console.ReadLine());

                int[] array = new int[10];
                Random random = new Random();

                Console.WriteLine("\n Old array");
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 13);
                    Console.Write(" " + array[i]);
                }


                Console.WriteLine("\n\n PRESS ENTER TO REPEAT");
                Console.ReadLine();
            }
            
        }

        private static int RemoveElement(int[] array, int input, int result)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == input)
                {

                    break;
                }
            }
            return result;
        }
    }
}
