using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] nummers = new int[3] { 1, 2, 3 };

 
            foreach (int i in nummers)
            {
                Console.WriteLine(i);
            }
        }
    }
}