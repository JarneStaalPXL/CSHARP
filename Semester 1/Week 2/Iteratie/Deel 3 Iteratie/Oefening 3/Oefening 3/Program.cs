using System;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double dividenum;

            double.TryParse(num, out dividenum);

            do
            {
                dividenum = dividenum / 2;
                Console.WriteLine(dividenum);
            } while (dividenum > 1); ;
        }
    }
}
