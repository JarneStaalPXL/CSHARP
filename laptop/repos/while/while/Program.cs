using System;

namespace bruh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een kleur");
            string input = Console.ReadLine();
            

            while (input == "rood")
            {
                Console.WriteLine($"Je koos {input}, goed!");
                input = Console.ReadLine();
            }
            do
            {
                Console.WriteLine("Foute kleur");
            } while (false);
        }
    }
}
