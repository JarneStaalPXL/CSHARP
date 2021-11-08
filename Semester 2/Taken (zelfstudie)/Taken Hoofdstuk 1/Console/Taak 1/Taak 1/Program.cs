using System;
using System.Diagnostics;
using System.IO;

namespace Taak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"taak1.txt";

            //using (StreamWriter sw = new StreamWriter(filePath, true)) //If you want to append  
            using (StreamWriter sw = new StreamWriter(filePath)) 
            {
                for (int i = 0; i < 15; i++)
                {
                    sw.Write($"{i}  ");
                }
            }

            Console.WriteLine("Succesfully writen to file");
            Process.Start("notepad",filePath);
        }
    }
}
