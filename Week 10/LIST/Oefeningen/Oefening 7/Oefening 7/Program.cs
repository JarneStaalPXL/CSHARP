using System;
using System.Collections.Generic;

namespace Oefening_7
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<int> list1 = new List<int>() ;
                List<int> list2 = new List<int>() ;


                Random random = new Random();

                for (int i = 0; i < 10; i++)
                {
                     list1.Add(random.Next(1, 40));
                     list2.Add(random.Next(1, 60));
                }




                Console.WriteLine("\n List 1");
                foreach (var item in list1)
                {
                    Console.Write(" " + item);
                }
                Console.WriteLine("\n\n List 2");
                foreach (var item in list2)
                {
                    Console.Write(" " + item);
                }

                Console.WriteLine("\n\n Does the second list contain a number that's also in the first list? ");
                Console.WriteLine(" "+Yeet(list1, list2));

                Console.WriteLine("\n PRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        public static bool Yeet(List<int> list1, List<int> list2)
        {
            foreach (var item in list1)
            {
                if (list2.Contains(item))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}