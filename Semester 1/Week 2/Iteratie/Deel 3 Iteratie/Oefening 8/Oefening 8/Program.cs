using System;

namespace Oefening_8
{
    class Program
    {
        static void Main(string[] args)
        {
                    Console.WriteLine("Oefening 8: Schrijf een programma dat de Pascal" +
                        " driehoek afdrukt voor een gegevenaantal rijen.");
                    Console.WriteLine();

                    int pascalRows;
                    while (true)
                    {
                        Console.WriteLine("Aantal rijen?");
                        if (int.TryParse(Console.ReadLine(), out pascalRows))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter an integer value!");
                    }

                    var functions = new functions();

                    for (int row = 0; row < pascalRows; row++)
                    {
                        for (int col = 0; col <= row; col++)
                        {
                            double numPascal = functions.Factorial(row) / ((functions.Factorial(row - col)) * functions.Factorial(col));
                            Console.Write(numPascal + " ");
                        }
                        Console.WriteLine();
                    }
                    Console.ReadLine();
                 }
        }


    }
    class functions
    {

        public double Factorial(int number)
        {
            if (number == 1 || number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }

    }