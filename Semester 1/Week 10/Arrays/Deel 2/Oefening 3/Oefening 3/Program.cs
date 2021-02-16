using System;

namespace Oefening_3
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
                }

                Console.WriteLine("Enter num");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine($"\nPositioned on the {Position(array, input)} place");

                Console.WriteLine("ENTER TO REPEAT");
                Console.ReadLine();

                Console.Clear();
            }

        }

        private static int Position(int[] array, int input)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (input == array[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
