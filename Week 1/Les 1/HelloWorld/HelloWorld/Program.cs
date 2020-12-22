using System;
using System.Collections.Generic;
using System.IO;

namespace Mama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            List<string> list1 = new List<string>();

            Console.WriteLine("Input a number from 1-100");
            int input = int.Parse(Console.ReadLine());




            string filePath = Directory.GetCurrentDirectory();
            string dbPath = System.IO.Path.Combine(filePath, $"RESULTS {DateTime.Now.ToString("d-M-yyyy")}");
            string inputFile = System.IO.Path.Combine(dbPath, "TheListOfShit.txt");
            System.IO.Directory.CreateDirectory(dbPath);


            while (true)
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[input];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                Console.WriteLine(finalString);

                StreamWriter writer = new StreamWriter(inputFile, true);
                for (int i = 0; i < 1; i++)
                {
                    writer.WriteLine(finalString);
                }
                writer.Close();

            }
        }
    }
}
