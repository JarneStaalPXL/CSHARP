using System;
using System.Collections.Generic;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<string> lijstVanWoorden = new List<string>() { "bloempot", "speakers", "muis", "pc" };
                Console.WriteLine(RandomElement(lijstVanWoorden));

                Console.WriteLine("PRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        private static string RandomElement(List<string> lijstVanWoorden)
        {
            Random random = new Random();
            return lijstVanWoorden[random.Next(0, lijstVanWoorden.Count)];
        }
    }
}
