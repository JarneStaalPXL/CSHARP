using System;

namespace Oefening_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] yeet = new int[5];
            yeet[0] = 1;
            yeet[1] = 2;
            yeet[2] = 4;
            yeet[3] = 4;
            yeet[4] = 3;
            Console.WriteLine(SumOfArray(yeet));
        }

        private static int SumOfArray(int[] yeet)
        {
            int sum = 0;
            for (int i = 0; i < yeet.Length; i++)
            {
                sum += yeet[i];
            }
             return sum;    
        }
    }
}
