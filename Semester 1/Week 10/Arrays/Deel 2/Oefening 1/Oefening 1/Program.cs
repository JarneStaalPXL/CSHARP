using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int[] array = new int[20];
                Random random = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(1, 10);
                }
                for (int j = 0; j < array.Length; j++)
                {
                  Console.Write($" " + array[j]);
                }
                Console.WriteLine("\n\nSum of even     numbers is " + SumEvenNumbers(array));

                //Optioneel
                //Console.WriteLine("Sum of uneven   numbers is " + SumUnEvenNumbers(array));

                Console.WriteLine("\nPress ENTER to repeat");
                string answer = Console.ReadLine();
                
                Console.Clear();
            }
        }

        private static int SumEvenNumbers(int[] array)
        {
            int sumEven = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sumEven += array[i];
                }
            }
            return sumEven;
        }

        //Optioneel
        //private static int SumUnEvenNumbers(int[] array)
        //{
        //    int sumUnEven = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] % 2 != 0)
        //        {
        //            sumUnEven += array[i];
        //        }
        //    }
        //    return sumUnEven;
        //}


    }
}
