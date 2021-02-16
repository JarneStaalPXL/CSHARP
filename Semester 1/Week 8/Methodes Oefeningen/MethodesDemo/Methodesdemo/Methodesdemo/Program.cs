using System;

namespace Methodesdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int aantalMensen = voorspelling(6000);

            BeleefdGroeten();

            string input = Console.ReadLine();
            int inputnum;
            bool num1 = int.TryParse(input, out inputnum);

            TimeSpan tijdsInterval = new TimeSpan(1, 0, 0);

            Random randomizer = new Random(10);
            int randomnum = randomizer.Next();
            Console.WriteLine(randomnum);
        }
        private static void BeleefdGroeten()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Goedemorgen Jarne");
            Console.WriteLine("Hoe kan ik u van dienst zijn?");
        }
        private static int voorspelling(int lastAmount)
        {
            double aantalMensen = lastAmount + 100;
            return (int)aantalMensen;
            //int aantalMensen = lastAmount + 100;
            //return aantalMensen;
        }
    }
}