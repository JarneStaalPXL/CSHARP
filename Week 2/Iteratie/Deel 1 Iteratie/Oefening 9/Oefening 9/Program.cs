using System;

namespace Oefening_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int resultaat = 1;
            // 5  ** 0 = 1, 5 ** 1 = 1 * 5 , 5 ** 2 = 1 * 5 * 5

            Console.WriteLine("Enter 2 numbers");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32 (Console.ReadLine());

            if (input2 > 0)
            {
                for (int i = 0; i < input2; i++)
                {
                    resultaat = (resultaat * input1);
                }
            }
            else
            {
                
            }
            Console.WriteLine(resultaat);
        }
    }
}