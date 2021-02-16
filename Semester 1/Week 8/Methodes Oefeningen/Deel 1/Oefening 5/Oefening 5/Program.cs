using System;

namespace Oefening_5
{
    class Program
    {
        public static int EigenMathPow(int grondtal, int exponent)
        {​​
                int result = 1;
                for (int i = 0; i < exponent; i++)
                {​​
                    result = result * grondtal;
                }​​
                return result;
      
        }​​

        public static void Main(string[] args)
        {
            Console.Write("Geef grondtal in: ");
            int grondtal = int.Parse(Console.ReadLine());
            Console.Write("Geef exponent in: ");
            int exponent = int.Parse(Console.ReadLine());

            Console.WriteLine("De resultaat is " + EigenMathPow(5));
        }
    }
}
