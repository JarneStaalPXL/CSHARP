using System;
using System.Collections.Generic;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Making a new list 
                List<int> intlist = new List<int>();

                //Adding data to the list manually via code
                intlist.Add(5);
                intlist.Add(2);
                intlist.Add(3);
                intlist.Add(5);
                intlist.Add(6);

                //Adding inputted numbers to list
                for (int i = 1; i < 5; i++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        Console.WriteLine($"Please enter number {i++}");
                        intlist.Add(int.Parse(Console.ReadLine())); 
                        Console.Clear();
                    }
                }


                //Adding random numbers to list
                //Random random = new Random();
                //for (int i = 0; i < 10; i++)
                //{
                //    intlist.Add(random.Next(1, 10));
                //}

                Console.WriteLine(" This is the list");
                for (int i = 0; i < intlist.Count; i++)
                {
                    Console.Write(" "+intlist[i]);
                }
                Console.WriteLine("\n\n This is the sum of the list "+ "\n "+ListSum(intlist));

                Console.WriteLine("\n PRESS ENTER TO REPEAT");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

        private static int ListSum(List<int> intlist)
        {
            int sum = 0;
            for (int i = 0; i < intlist.Count; i++)
            {
                sum += intlist[i];
            }
            return sum;
        }
    }
}
