using System;
using System.Linq;

namespace Oefening_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aantal rijen hoog?");
            int heightPyramid = Convert.ToInt32(Console.ReadLine());
            for (int i = heightPyramid; i > 0; i--)
            {
                string basePyramid = "";
                basePyramid += String.Concat(Enumerable.Repeat(" ", i - 1));
                basePyramid += String.Concat(Enumerable.Repeat("x", 2 * (heightPyramid - i) + 1));
                Console.WriteLine(basePyramid);
            }
        }
    }
}
