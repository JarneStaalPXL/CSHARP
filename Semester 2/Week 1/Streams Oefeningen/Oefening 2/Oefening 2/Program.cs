using System;
using System.Diagnostics;
using System.IO;


namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Input file name you want to delete it's content if excists. If doesn't excist, it will create one.");
                string filename = Console.ReadLine();
                string path1 = $@"{filename}.txt";

                FileInfo fi = new FileInfo(path1);

                if (fi.Exists)
                {
                    Wipe(fi, path1);
                }
                else
                {
                    Console.WriteLine("File does not exist and is created with content.");
                    using (StreamWriter sw = new StreamWriter(path1))
                    {
                        sw.WriteLine("qzoidjk iozqidojzq oid zqçijd çiqzj  diojzq");
                        sw.WriteLine("qzoidjk iozqidojzq oid zqçijd çiqzj  diojzq");
                        sw.WriteLine("qzoidjk iozqidojzq oid zqçijd çiqzj  diojzq");
                        sw.WriteLine("qzoidjk iozqidojzq oid zqçijd çiqzj  diojzq");
                        sw.WriteLine("qzoidjk iozqidojzq oid zqçijd çiqzj  diojzq");
                    }
                }

                Console.WriteLine("Below the content of the file. If empty, it worked. If not empty, there was no file named like that");
                Console.WriteLine(File.ReadAllText(path1));


                OpenFile(path1);

                Console.WriteLine("Press ENTER");
                Console.ReadLine();
            }
            
        }

        static void Wipe(FileInfo fi, string path1)
        {
            using (StreamWriter sw = new StreamWriter(path1))
            {
                sw.WriteLine();
            }
        }

        static void OpenFile(string path1)
        {
            Process.Start("notepad", path1);
        }
    }
}
