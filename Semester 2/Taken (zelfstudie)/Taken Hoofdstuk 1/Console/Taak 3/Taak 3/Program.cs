using System;
using System.Diagnostics;
using System.IO;

namespace Taak_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"tekstbestand.txt";

            // Writing to a file that's given access to write + appendmode
            using (FileStream fsWrite = new FileStream(filePath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fsWrite))
                {
                    sw.WriteLine(" Volgorde van getallen:");
                    for (int i = 0; i < 10; i++) 
                        sw.Write(i + " ");
                    sw.WriteLine();
                }
            }

            string filePath2 = @"tekstbestand.txt";
            // Reading a file using FileStream
            using (FileStream frRead = new FileStream(filePath2, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(frRead))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }

            Process.Start("notepad", filePath);
        }
    }
}
