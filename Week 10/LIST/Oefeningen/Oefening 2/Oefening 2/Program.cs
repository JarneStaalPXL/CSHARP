using System;
using System.Collections.Generic;

namespace Oefening_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            stringlist.Add("Hallo");
            stringlist.Add("Hallo");
            stringlist.Add("Hallo");

            stringlist = ConcatEach(stringlist, " !!!");


            foreach (string tekst in stringlist)
            {
                Console.WriteLine(tekst);
            }
            

        }

        private static List<string> ConcatEach(List<string> stringlist, string aanhangsel)
        {
            for (int i = 0; i < stringlist.Count; i++)
            {
                stringlist[i] = stringlist[i] + aanhangsel;
            }

            return stringlist;
        }
    }
}
