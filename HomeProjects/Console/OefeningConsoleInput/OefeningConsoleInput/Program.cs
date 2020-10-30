using System;

namespace OefeningConsoleInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is uw naam ?");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is uw leeftijd?");
            int leeftijd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bent u een man? true of false");
            bool isMan = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Wat is uw telefoonnummer?");
            string telefoonnummer = Console.ReadLine();
            Console.WriteLine("Wat is uw email?");
            string email = Console.ReadLine();
            Console.WriteLine("Wat is uw postcode?");
            int postcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is uw woonplaats?");
            string woonplaats = Console.ReadLine();



            Console.WriteLine("Naam = " + naam);
            Console.WriteLine("Leeftijd = " + leeftijd);
            Console.WriteLine("isMan = " + isMan);
            Console.WriteLine("Telefoonnummer = " + telefoonnummer);
            Console.WriteLine("E - mail = " + email);
            Console.WriteLine("Postcode - Woonplaats = " + postcode + " - " + woonplaats);



        }
    }
}
