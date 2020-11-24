using System;

namespace Oefening_2
{
    class Program
    {
        
		private static double Oefening2OmtrekCirkel(double straal)
        {
			return 2 * Math.PI * straal;
        }
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("\n Geef een nummer mee die de straal moet voorstellen");
				double straal = Convert.ToInt32(Console.ReadLine());

				Console.Clear();

				double omtrek = Oefening2OmtrekCirkel(straal)

				// Zonder format-strings kan handig zijn ...
				Console.WriteLine("Voor een cirkel van straal " + straal);
				Console.WriteLine("Omtrek: " + omtrek);
			}

		}


	}
}
