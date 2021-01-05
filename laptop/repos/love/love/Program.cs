using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Timers;
using System.Security.Cryptography;

namespace love
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef de namen van het koppel");
            string koppel = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"\nHouden {koppel} van elkaar?\n");
            string answer = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"\nMissen {koppel} elkaar elke dag?\n");
            string answer1 = Console.ReadLine();

            if ("Jaja".Contains(answer1))
            {
                Console.WriteLine("Jullie zijn voor elkaar bestemd.\nGeniet van een prachtig leven samen <3");
            }
            else
            {
                Console.WriteLine("Waarom zou je nee zeggen....");
            }
            Console.ReadKey();
            
        }
    }
}
