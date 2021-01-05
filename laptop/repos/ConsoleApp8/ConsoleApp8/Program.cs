using System;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath2 = Directory.GetCurrentDirectory();
            string dbPath2 = System.IO.Path.Combine(filePath2, $"RESULTS {DateTime.Now.ToString("d-M-yyyy")}");
            string inputFile2 = System.IO.Path.Combine(dbPath2, "GameSession.txt");
            System.IO.Directory.CreateDirectory(dbPath2);
            File.Create(inputFile2);


            Console.WriteLine("\n\nFilepath2 = " +filePath2);
            Console.WriteLine("\n\ndbPath2 = " + dbPath2);
            Console.WriteLine("\n\ninputFile2 = " + inputFile2);


        }
    }
}
