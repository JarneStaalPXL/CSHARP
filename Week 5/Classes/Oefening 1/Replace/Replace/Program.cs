    using System;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Input num \n");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input num2 \n");
                int b = Convert.ToInt32(Console.ReadLine());


                int temp = a;
                a = b;
                b = temp;

                Console.Clear();

                Console.WriteLine($"int a = {a}");
                Console.WriteLine($"int b = {b}");


                Console.WriteLine("Redo? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "n")
                {
                    break;
                }
            }
        }
    }
}
