using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input num");
            int input = Convert.ToInt32(Console.ReadLine());

            int result = input * input;
            string output = "";

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    output += result + " ";
                    result--;
                }
                output += "\n";
            }
            Console.WriteLine($"{output,4}");
            }
        }
    }
