using System;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 6: Schrijf een programma dat de eerste n elementen" +
                        " afdrukt van de Fibonacci reeks.");

                    int numsInSeries;
                    while (true)
                    {
                        Console.WriteLine("Geef een getal in");
                        if (int.TryParse(Console.ReadLine(), out numsInSeries))
                        {
                            break;
                        }
                        Console.WriteLine("Please enter an integer value!");
                    }
                    int fibOne = 0;
                    int fibTwo = 1;
                    int fib;
                    if (numsInSeries > 2)
                    {

                        Console.Write("0 ");
                        Console.Write("1 ");
                        for (int i = 0; i < numsInSeries - 2; i++)
                        {
                            fib = fibOne + fibTwo;
                            Console.Write(fib + " ");
                            fibOne = fibTwo;
                            fibTwo = fib;
                        }
                    }
                    else if (numsInSeries < 2 && numsInSeries > 1)
                    {
                        Console.WriteLine("0 1");
                    }
                    else
                    {
                        Console.WriteLine("0");
                    }
        }
    }
}
