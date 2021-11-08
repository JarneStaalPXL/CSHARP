using System;
using System.Diagnostics;
using System.IO;

namespace Taak_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"tekst.txt";

            // Writing to the file only if the file doesn't excist yet
            if (!File.Exists(filePath))
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    for (int i = 0; i < 20; i++)
                    {
                        sw.WriteLine(i);
                    }
                }
            }


            // Reading the file 
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    Console.Write(sr.ReadLine()+" ");
                }
            }

            Process.Start("notepad", filePath);


        }
    }
}
