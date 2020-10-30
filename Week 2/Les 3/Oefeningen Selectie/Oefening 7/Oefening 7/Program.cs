using System;
using System.Reflection.Metadata.Ecma335;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een jaar in");
            int input = Convert.ToInt32(Console.ReadLine());
            if (DateTime.IsLeapYear(input))
            {
                Console.WriteLine(input + "  is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine(input + "  is geen schikkeljaar");
            }
        }
    }
}

            //int jaartal;
            //if int.TryParse(Console.ReadLine(), out jaartal));
            //{
            //    if (jaartal % 400 == 0)
            //    {
            //        Console.WriteLine("Het jaartal is een schrikkeljaar");
            //    }
            //    else if (jaartal % 100 == 0 && jaartal % 400 != 0)
            //    {
            //      Console.WriteLine("Het jaartal is geen schrikkeljaar");
            //    }
            //    else if (jaartal % 4 == 0)
            //    { 
            //        Console.WriteLine("Het jaartal is geen schrikkeljaar");
            //    }
            //  }
            //  else
            //  {
            //    Console.WriteLine("Ongeldige Input");
            //  }
