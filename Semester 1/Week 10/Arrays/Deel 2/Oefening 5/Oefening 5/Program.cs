using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input length of first array");
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("Input length of second array");
                int input2 = int.Parse(Console.ReadLine());

                int[] array1 = new int[input];
                int[] array2 = new int[input2];


                Random random = new Random();
                for (int i = 0; i < array1.Length; i++)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        array1[i] = random.Next(1, input);
                        array2[j] = random.Next(1, input2);
                    }    
                }

                Console.WriteLine("Length off first array = "+ array1.Length + "\nLength of second array = "+ array2.Length );

                if (HaveEqualLength(array1,array2) == true)
                {
                     Console.WriteLine("The arrays have the same length");
                }
                else if (HaveEqualLength(array1, array2) == false)
                {
                     Console.WriteLine("The arrays don't have the same length");
                }

                Console.WriteLine("\nPress ENTER to repeat");
                Console.ReadLine();
                Console.Clear();
            }
        }


        private static bool HaveEqualLength(int[] array1, int[] array2)
        {
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1.Length == array2.Length)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
