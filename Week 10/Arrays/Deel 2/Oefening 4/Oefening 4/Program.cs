using System;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int[] reeks = new int[10];
                Random random = new Random();


                Console.WriteLine("Enter minimum value");
                int input1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter maximum value");
                int input2 = int.Parse(Console.ReadLine());

                Console.Clear();
                for (int i = 0; i < reeks.Length; i++)
                {
                    reeks[i] = random.Next(input1, input2);
                    Console.Write(" " + reeks[i]);
                }

                if (IsPositief(reeks) == true)
                {
                    Console.WriteLine($"\nArray contains negatives");
                }
                else
                {
                    Console.WriteLine($"\nArray contains positives");
                }

                Console.WriteLine("\nENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
        }

        private static bool IsPositief(int[] reeks)
        {
            for (int i = 0; i < reeks.Length; i++)
            {
                if (reeks[i] < 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
