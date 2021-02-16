using System;

namespace Oefening_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Primes between 0 and 100 ---");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0;

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }
            if (a == 2)
            {
                Console.WriteLine($"{n} Is A Prime Number", n);
            }
            else
            {
                Console.WriteLine($"{n} Is Not A Prime Number");
            }
        }
        }
    }