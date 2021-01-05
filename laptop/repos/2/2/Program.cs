using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int number = 100;
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
