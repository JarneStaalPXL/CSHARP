using System;

namespace Oefening_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100;
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"alle veelvouden van 2 en 5 onder {number} is {sum}");
        }
    }
}
