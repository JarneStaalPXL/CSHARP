using System;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Total sides?");
                int totalsides = int.Parse(Console.ReadLine());

                Random num = new Random();
                int generatednum = num.Next(1, totalsides);

                Console.WriteLine($"\nGenerated number is {generatednum}\n");
                
            }
        }
    }
}
