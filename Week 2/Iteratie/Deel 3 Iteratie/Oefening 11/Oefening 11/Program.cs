using System;

namespace Oefening_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int numrows;

            if (int.TryParse(input, out numrows))
            {
                for (int i = 0; i <= numrows; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
