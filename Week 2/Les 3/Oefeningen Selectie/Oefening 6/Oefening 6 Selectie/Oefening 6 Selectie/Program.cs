using System;

namespace Oefening_6_Selectie
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            Console.WriteLine(days);
        }
    }
}
