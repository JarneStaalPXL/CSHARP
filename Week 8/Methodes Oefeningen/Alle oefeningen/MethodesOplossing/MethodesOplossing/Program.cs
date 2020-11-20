using System;

namespace MethodesOplossing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Oefening 1
            Console.WriteLine("\nOefening 1\n");
            int getal = 10, getal2 = 20;
            Console.WriteLine($"{getal} {getal2}");
            VerWissel(ref getal, ref getal2);
            Console.WriteLine($"{getal} {getal2}");

            // Oefening 2
            Console.WriteLine("\nOefening 2\n");
            int straal = 3;
            Console.WriteLine($"De omtrek van een cirekl met straal {straal} is {BerekenOmtrek(straal)}");

            // Oefening 3
            Console.WriteLine("\nOefening 3\n");
            RandomSquare();

            // Oefening 4
            Console.WriteLine("\nOefening 4\n");
            int a = 20, b = 30, c = 51;
            Console.WriteLine($"{a} + {b} + {c} > 100 ? {IsGroterDanHonderd(a, b, c)}");

            // Oefening 5
            Console.WriteLine("\nOefening 5\n");
            int grondtal = 2, exponent = 3;
            Console.WriteLine($"{grondtal}^{exponent} = {Macht(grondtal, exponent)}");

            // Oefening 6
            Console.WriteLine("\nOefening 6\n");
            Console.WriteLine(BerekenBTW(100.00));

            // Oefening 7
            Console.WriteLine("\nOefening 7\n");
            double nummer = 2;
            Console.WriteLine(nummer);
            Verdubbel(ref nummer);
            Console.WriteLine(nummer);

            // Oefening 8
            Console.WriteLine("\nOefening 8\n");
            string resultaat;
            bool kanBetalen = IsVoldoendeBudget(10, 15, out resultaat);
            Console.WriteLine($"{kanBetalen}: {resultaat}");

            // Oefening 9
            Console.WriteLine("\nOefening 9\n");
            Console.WriteLine(Factorial(5));

            // Oefening 10
            Console.WriteLine("\nOefening 10\n");
            NextFibonacci(0, 1);

        }

        // Oefening 1 
        private static void VerWissel(ref int a, ref int b)
        {
            int tempA = b;
            a = b;
            b = tempA;
        }

        // Oefening 2
        private static double BerekenOmtrek(double straal)
        {
            return 2 * Math.PI * straal;
        }

        // Oefening 3 a
        private static string HashtagOfProcent(int a)
        {
            if (a % 2 == 0)
            {
                return "#";
            }
            else
            {
                return "%";
            }
        }

        // Oefening 3 b
        private static void RandomSquare()
        {
            Random randomizer = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int randomGetal = randomizer.Next(0, 2);
                    Console.Write($"{HashtagOfProcent(randomGetal)} ");
                }
                Console.WriteLine();
            }
        }

        // Oefening 4
        private static bool IsGroterDanHonderd(int a, int b, int c)
        {
            if (a + b + c > 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Oefening 5
        private static double Macht(double grondtal, double exponent)
        {
            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result = result * grondtal;
            }
            return result;
        }

        // Oefening 6
        private static decimal BerekenBTW(decimal bedrag)
        {
            decimal procent = 0.21m;
            return bedrag * procent;
        }

        // Oefening 6
        private static float BerekenBTW(float bedrag)
        {
            float procent = 0.21f;
            return bedrag * procent;
        }

        // Oefening 6
        private static double BerekenBTW(double bedrag)
        {
            double procent = 0.21;
            return bedrag * procent;
        }

        // Oefening 7
        private static void Verdubbel(ref double getal)
        {
            getal = getal * 2;
        }

        // Oefening 8
        public static bool IsVoldoendeBudget(double totaalWinkelkar, double budgetKlant, out string feedback)
        {
            if (totaalWinkelkar <= budgetKlant)
            {
                feedback = "Je kan de winkelkar succesvol betalen.";
                return true;
            }
            else
            {
                double tekort = totaalWinkelkar - budgetKlant;
                feedback = $"Je komt {tekort} euro te kort.";
                return false;
            }
        }

        // Oefening 9
        private static void NextFibonacci(int a, int b)
        {
            Console.WriteLine(a);
            if (b < 100)
            {
                NextFibonacci(b, a + b);
            }
        }

        // Oefening 10
        private static int Factorial(int a)
        {
            return FactorialResult(a, 1);
        }

        private static int FactorialResult(int a, int result)
        {
            if (a > 1)
            {
                return FactorialResult(a - 1, result * a);
            }
            return result;
        }
    }
}
