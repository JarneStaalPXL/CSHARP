
using System;

namespace Oefening_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double number2 = 1000000;
            double sum2 = 0;

            for (int i = 1; i < number2; i++)
            {
                if (i % 2 == 0 || i % 5 == 0)
                {
                    sum2 += i;
                }
            }

            Console.WriteLine($"alle veelvouden van 2 en 5 onder {number2} is {sum2}");
        }
    }
}
