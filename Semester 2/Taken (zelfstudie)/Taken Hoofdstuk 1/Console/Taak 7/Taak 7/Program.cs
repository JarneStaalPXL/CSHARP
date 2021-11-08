using System;
using System.IO;

namespace Taak_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"tekst.txt";

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < 15; i++)
                {
                    sw.WriteLine("Hello there " + i);
                }
            }

            Console.WriteLine("File ReadAllText");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.WriteLine("\n\n\nFile ReadAllLines");
            string[] array = File.ReadAllLines(filePath);

            foreach (var item in array)
            {
                Console.Write(item + " "  );
            }    
        }
    }
}
