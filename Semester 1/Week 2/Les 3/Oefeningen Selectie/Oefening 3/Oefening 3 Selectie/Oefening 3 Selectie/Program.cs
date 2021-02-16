using System;

namespace Oefening_3_Selectie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een getal in");
            int z;
            bool isGelukt = int.TryParse(Console.ReadLine(), out z);

            if (isGelukt)
            {
                if (z % 5 == 0)
                {
                    Console.WriteLine("deelbaar door 5");
                }
                else if (z % 6 == 0)
                {
                    Console.WriteLine("deelbaar door 6");
                }
                else
                {
                    Console.WriteLine("niet deelbaar door vijf of zes");
                }
            }
            else
            {
                Console.WriteLine("Dit is geen geldige input");
            }


            Console.Write("\nDemonstratie van Console.Write\ndit ");
            Console.Write("is ");
            Console.Write(" tekst op één lijn\n");
        }
    }
}
