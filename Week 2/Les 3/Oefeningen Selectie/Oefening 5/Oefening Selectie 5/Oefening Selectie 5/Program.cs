using System;

namespace Oefening_Selectie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());

            if(score <= 5)
            {
                Console.WriteLine("erg slecht");
            }
            else if (score >= 5 && score <= 10)
            {
                Console.WriteLine("gebuisd");
            }
            else if (score >= 10 && score <= 13)
            {
                Console.WriteLine("geslaagd");
            }
            else if (score >= 14 && score <= 16)
            {
                Console.WriteLine("goed");
            }
            else if (score >= 16 && score <= 20)
            {
                Console.WriteLine("geweldig");
            }
            
        }
    }
}

