using System;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random num = new Random();
                int generatednum = num.Next(1, 6); //for ints

                Console.Write($"Generated number is  {generatednum}\n");


                Console.WriteLine("\nPress ENTER to throw again\n");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "n")
                {
                    break;
                }
                Console.Clear();
            }
            
        }
    }
}
