using System;

namespace Oefening_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("aantal rijen?");
            int maxRows = Convert.ToInt32(Console.ReadLine());
            int tempNumber = 1;
            for (int rows = 0; rows < maxRows; rows++)
            {
                for (int cols = 0; cols < maxRows; cols++)
                {
                    if (tempNumber < 10)
                    {
                        Console.Write(" " + tempNumber);
                    }
                    else
                    {
                        Console.Write(tempNumber);
                    }
                    tempNumber++;
                }
                Console.WriteLine();
            }
        }
    }
}
