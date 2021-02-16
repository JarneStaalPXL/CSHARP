using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vijfstudenten = new string[5];
            for (int i = 0; i < vijfstudenten.Length; i++)
            {
                Console.Write("Input names: ");
                vijfstudenten[i] = Console.ReadLine();
                Console.Clear();
            }
            //for (int i = 0; i < vijftienstudenten.Length; i++)
            //{
            //    Console.Write($"{vijftienstudenten[i]}  ");
            //}
            Console.WriteLine("Enter number");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(vijfstudenten[input]); 
        }
    }
}
