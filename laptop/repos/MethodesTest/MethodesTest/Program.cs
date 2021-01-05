using System;

namespace MethodesTest
{
    class Program
    {

        private static double plus(double a, double b)
        {
            double sum = a + b;
            return sum;
        }

        private static double maal(double a, double b)
        {
            double multiplication = a * b;
            return multiplication;
        }

        private static double gedeeldoor(double a, double b)
        {
            double divide = a / b;
            return divide;
        }

        private static double min(double a, double b)
        {
            double divide = a - b;
            return divide;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Kies tussen\n   +\n   -\n   *\n   /\n");
                string answer = Console.ReadLine();
                if (answer  == "+")
                {
                    Console.Clear();
                    double a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Geef nog een getal in");
                    double b = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{a} + {b} = {plus(a, b)}\n");
                }
                else if (answer == "-")
                {
                    Console.Clear();
                    Console.WriteLine("Geef een getal in ");
                    double a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Geef nog een getal in");
                    double b = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{a} - {b} = {min(a, b)}\n");
                }
                else if (answer == "*")
                {
                    Console.Clear();
                    Console.WriteLine("Geef een getal in ");
                    double a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Geef nog een getal in");
                    double b = int.Parse(Console.ReadLine());

                    Console.WriteLine($"{a} * {b} = {maal(a, b)}\n");
                }
                else if (answer == "/")
                {
                    Console.Clear();
                    Console.WriteLine("Geef een getal in ");
                    double a = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Geef nog een getal in");
                    double b = int.Parse(Console.ReadLine());


                    Console.WriteLine($"{a} / {b} = {gedeeldoor(a, b)}\n");
                }
                else if (answer == "stop")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ongeldige Input.\n");
                }

            }

            
        }
    }
}
