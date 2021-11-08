using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQOefeningen
{
    class Program
    {

        static void Main(string[] args)
        {

            Oefening1();
           



            
            

        }


        public static void Oefening1()
        {
            List<int> driehoek = new List<int>()
            {
            1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
            1, 3, 6, 10, 15, 21, 28, 36, 45,
            1, 4, 10, 20, 35, 56, 84, 120,
            1, 5, 15, 35, 70, 126, 210,
            1, 6, 21, 56, 126, 252,
            1, 7, 28, 84, 210,
            1, 8, 36, 120,
            1, 9, 45,
            1, 10,
            1
            };

            string[] tekst = new string[]
           {
                "langspeelfilm", "vluchtmisdrijf", "dovemansgesprek", "containerpark",
                "confituur", "inox", "valavond", "enerverend", "lopen", "bank", "vieruurtje",
                "waterzooi", "maaltijdcheque", "arrondissement", "eindtermen", "nieuwjaarsbrief"
           };



            #region Oefening 1 A
            Console.WriteLine("Oefening A\n");
            var text = from item in tekst
                       where item.Length <= 10
                       orderby item
                       select item;

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Oefening 1 B

            Console.WriteLine("\n\nOefening B\n");
            var result = from item in driehoek
                         where item > 100
                         orderby item
                         select item;

            var result2 = result.Average();

            Console.WriteLine(result2);
            #endregion


            #region Oefening 1 C
            Console.WriteLine("\n\nOefening C\n");
            var result3 = driehoek.Distinct();

            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Oefening 1 D
            Console.WriteLine("\n\nOefening D\n");
            var result4 = from item in result3
                          where item % 3 == 0
                          where item % 5 == 0
                          orderby item ascending
                          select item;

            foreach (var item in result4)
            {
                Console.WriteLine(item);
            }


            #endregion



            #region Oefening 1 E
            Console.WriteLine("\n\nOefening E\n");

            var text2 = from item in tekst
                        where item.Length > 0
                        orderby item.Length ascending
                        select item;

            foreach (var item in text2)
            {
                Console.WriteLine(item);
            }



            Console.WriteLine("\n\n");
            var aflopendTekst = from item in tekst
                                where item.Length <= tekst.Length
                                orderby item.Length ascending
                                select item;

            foreach (var item in aflopendTekst)
            {
                Console.WriteLine(item);
            }

            #endregion

            //f --- WRONG
            Console.WriteLine("\n\nOefening F\n");
            string[] array;

            var text3 = from item in tekst
                        where item == item.Substring(0, 1) //wrong
                        orderby item
                        select item;


            foreach (var item in text3)
            {
                Console.WriteLine(item);
            }


            //g





            //i

            var vowelCount = tekst.Count(c => "aeiou".Contains(Char.ToLower(c)));



        }

    }
}