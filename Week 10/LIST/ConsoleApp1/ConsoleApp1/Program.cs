using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lijstVanStrings;
            Dictionary<string, double> dictionaryMetFavorieteGetallen = new Dictionary<string, double>()
            {
                {"Sander", 2.71828 },
                {"Jarne", 3.14 },
                {"Omer", 4.500 },
            };

            while (true)
            {
                Console.WriteLine("Input name");
                string key = Console.ReadLine();

                StringBuilder consoleTextBuilder = new StringBuilder();

               
                //dictionaryMetFavorieteGetallen.Add("Sander", 2); // Remove this
                consoleTextBuilder.AppendLine(dictionaryMetFavorieteGetallen[key].ToString());

                Console.WriteLine($"\nValue of {key} = "+consoleTextBuilder.ToString());
            }
            
        }
    }
}
