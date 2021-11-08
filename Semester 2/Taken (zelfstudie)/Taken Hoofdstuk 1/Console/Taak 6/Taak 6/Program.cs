using System;
using System.IO;

namespace Taak_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"tekst.txt";
            string filePath2 = @"tekst2.txt";

            // Write to file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("I AM");
            }


            //Write do different file and reading it after to append it with first file
            string textFromFile2;
            using (StreamWriter sw = new StreamWriter(filePath2))
            {
                sw.WriteLine("GAY");
            }
            textFromFile2 = File.ReadAllText(filePath2);


            File.AppendAllText(filePath, textFromFile2);


            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}
