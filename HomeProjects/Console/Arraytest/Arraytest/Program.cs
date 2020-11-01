using System;
using System.IO;
using System.Diagnostics;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many names do you want to add?");
            int input = int.Parse(Console.ReadLine());

            Console.Clear();


            string[] names = new string[input];
            string[] adress = new string[input];


            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("\nFirst Name & Last Name: ");
                names[i] = Console.ReadLine();
                Console.Write("\nAdress: ");
                adress[i] = Console.ReadLine();
                Console.Clear();
            }


            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";


            string dbPath = System.IO.Path.Combine(filePath, "Database");
            System.IO.Directory.CreateDirectory(dbPath);


            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");

            Console.Clear();
            const string UNDERLINE = "\x1B[4m";
            const string RESET = "\x1B[0m";
            Console.WriteLine(UNDERLINE + "\nSubmitted Data\n" + RESET);


            StreamWriter writer = new StreamWriter(inputFile, true);
            DateTime date1 = DateTime.Now;
            writer.WriteLine($"------------------USER INFO------------------ \n{date1.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n");
            for (int j = 0; j < names.Length; j++)
            {
                writer.WriteLine($"Name: {names[j]}");
                writer.WriteLine($"Adress: {adress[j]}\n");
            }
            writer.Close();


            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]} \n");
                Console.WriteLine($"Adress: {adress[i]} \n");
            }

            Process myProcess = new Process();
            Process.Start("notepad", @"C:\Users\12001144\OneDrive - PXL\PXL C#\HomeProjects\Console\Arraytest\Arraytest\bin\Debug\netcoreapp3.1\Database\SubmittedUserInfo.txt");
        }
    }
}
