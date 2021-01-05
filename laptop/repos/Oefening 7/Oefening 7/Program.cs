using System;

namespace Oefening_7
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
                    array[i] = random.Next(1, 11);
                    Console.Write($" " +array[i]);
                }
                SmallestElement(array);

                Console.WriteLine("PRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
           
        }

        private static int SmallestElement(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[i])
                {
                    return i;
                }
            }
            Console.WriteLine("\n" +i);
        }
    }
}
