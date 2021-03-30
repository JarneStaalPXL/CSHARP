using System;
using System.IO;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();

            string path = @"Text.txt";
            string a = $"Goedemorgen {name}";
            string b = $"Goedendag {name}";
            string c = $"Goedenavond {name}";

            using (StreamWriter sw = new StreamWriter(path))
            {
                TimeSpan time = DateTime.Now.TimeOfDay;

                if (time > new TimeSpan(00, 00, 01)        //Hours, Minutes, Seconds
                 && time < new TimeSpan(12, 00, 00))
                {
                    sw.WriteLine(a);
                }
                else if (time > new TimeSpan(12, 00, 01)        //Hours, Minutes, Seconds
                 && time < new TimeSpan(17, 00, 00))
                {
                    sw.WriteLine(b);
                }
                else
                {
                    sw.WriteLine(c);
                }

                
            }
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
