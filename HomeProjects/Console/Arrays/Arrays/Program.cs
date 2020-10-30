using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many names do you want to add?");
            int input = int.Parse(Console.ReadLine());

            string[] names = new string[input];
            
            for (int i = 0; i <names.Length; i++)
            {
                Console.Write("\nName: ");  
                names[i] = Console.ReadLine();
            }

            Console.Clear();
            const string UNDERLINE = "\x1B[4m";
            const string RESET = "\x1B[0m";
            Console.WriteLine(UNDERLINE + "\nSubmitted Names\n" + RESET);

            for (int i = 0; i < names.Length; i++)
            {
               Console.WriteLine($"{names[i]}\n");
            }


        }
    }
}
