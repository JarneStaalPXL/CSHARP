using System;

namespace ozidzj
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Input number");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a < 5)
            {
                Console.WriteLine("Erg Slecht");
            }
            else if (a >= 5 && a < 10)
            {
                Console.WriteLine("Gebuisd");
            }
            else if (a >= 10 && a <= 13)
            {
                Console.WriteLine("Geslaagd");
            }
            else if (a >= 14 && a < 16)
            {
                Console.WriteLine("Goed");
            }
            else if (a >= 16 && a <= 20)
            {
                Console.WriteLine("Geweldig");
            }
            else
            {
                Console.WriteLine("Geen geldige input");
            }
        }
    }
}