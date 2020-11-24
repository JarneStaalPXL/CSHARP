using System;

namespace Oefening_3_console
{
    class Program
    {
        public static bool IsVraag(string stuktekst)
        {
            char vraagteken = Convert.ToChar("?");

            if (Convert.ToChar(stuktekst.Substring(stuktekst.Length - 1)) == vraagteken)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Vraag iets of geef een zin in");
                string stuktekst = Console.ReadLine();
                Console.WriteLine($"\n{IsVraag(stuktekst)}");
            }
        }
    }
}
