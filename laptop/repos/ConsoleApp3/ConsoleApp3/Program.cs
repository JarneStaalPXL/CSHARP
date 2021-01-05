using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number");
            int input = Convert.ToInt32(Console.ReadLine());
            string uitvoer = "";

            int result = input * input;

            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    uitvoer += result + " ";
                    result--;
                }
                uitvoer += "\n";
            }
            Console.WriteLine($"{uitvoer,4}");
            }
            
        }
    }

