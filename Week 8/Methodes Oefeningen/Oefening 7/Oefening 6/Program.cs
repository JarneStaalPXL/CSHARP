using System;

namespace Oefening_6
{
    class Program
    {
        private static void MaalVier (ref int a)
        {
            a = a * 4;
        }

        static void Main(string[] args)
        {
            int b = 20;
            MaalVier(ref b);
            Console.WriteLine(b);
        }
    }
}
