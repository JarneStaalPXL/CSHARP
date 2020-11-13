using System;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
				Console.WriteLine("\n Geef een nummer mee die de straal moet voorstellen");
				double straal = Convert.ToInt32(Console.ReadLine());

				Console.Clear();

				double omtrek = 2 * Math.PI * straal;

				// Zonder format-strings kan handig zijn ...
				Console.WriteLine("Voor een cirkel van straal " + straal);
				Console.WriteLine("Omtrek: " + omtrek);
			}

		}
    }
}
