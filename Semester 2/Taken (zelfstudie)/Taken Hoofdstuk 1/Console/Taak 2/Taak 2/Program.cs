using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Taak_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Making a text file and filling it up
            string filePath = @"tekst.txt";
            using (StreamWriter sw = new StreamWriter(filePath)) 
            {
                sw.WriteLine("Dit is de 1ste regel");
                for (int i = 2; i <= 10; i++)
                {
                    sw.WriteLine($"Dit is de {i}de regel");
                }
            }

            //Making a list and adding every line of text file to the list
            List<string> list = new List<string>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }

            //Showing the list 
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }



            Process.Start("notepad", filePath);
        }
    }
}
