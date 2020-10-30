using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal > 1000) 
            {
                Console.WriteLine("Groter dan 1000");
            }
            else
            {
                Console.WriteLine("kleiner");
            };
            if (getal == 5) Console.WriteLine("het is vijf");
        }
    }
}