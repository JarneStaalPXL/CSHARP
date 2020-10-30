using System;

namespace Winstmarge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is de oorspronkelijke kost van het product?");
            string antwoord = Console.ReadLine();
            double aankoopPrijs = Convert.ToDouble(Console.ReadLine());
            double resultaat = aankoopPrijs * 1.9;
            Console.WriteLine("De verkoopprijs is:"  + resultaat);
        }
    }
}
