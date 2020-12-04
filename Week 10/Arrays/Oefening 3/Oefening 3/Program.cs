using System;
using System.Linq;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {

            //Oefening 3
            //int[] rij = RandomTien();
            //for (int i = 0; i < rij.Length; i++)
            //{
            //    Console.Write($"  { rij[i]}");
            //}

            //Alternatief
            //Console.WriteLine(String.Join(" ", rij));


            //Oefening 4
            //int[] rij1 = SomInts(tiengetallen);
            //for (int i = 0; i < rij1.Length; i++)
            //{
            //    Console.WriteLine(rij1[i]);
            //}


            //Oefening 5
            int max = 0;
                int min = 0;
            //int max = int.MinValue;
            //int min = int.MinValue;
            int[] andereRij = RandomTien();
            if (andereRij.Length > 0)
            {
                max = andereRij[0];
                min = andereRij[0];
            }

            //controleer alle waardes
            for (int i = 0; i < andereRij.Length; i++)
            {
                //controleer of het groter is dan huidig max
                if (andereRij[i] > max)
                {
                    max = andereRij[i];
                }

                if (andereRij[i] < min)
                {
                    min = andereRij[i];
                }
            }
            Console.WriteLine($"Min = {min}, Max = {max}");



        }

        private static int[] RandomTien()
        {
            int[] tiengetallen = new int[10];

            //Oefening 3
            Random random = new Random();
            for (int i = 0; i < tiengetallen.Length; i++)
            {
                tiengetallen[i] = random.Next(1, 11);
            }
            return tiengetallen;
        }

        private static int SomInts(int[] tiengetallen)
        {
            //Oefening 4
            int sum = 0;
            for (int i = 0; i < tiengetallen.Length; i++)
            {
                sum += tiengetallen[i];
            }

            return sum;
        }

        private static int Minimum(int[] tiengetallen)
        {

            //Oefening 5
            for (int i = 0; i < tiengetallen.Length; i++)
            {
                if (tiengetallen[1] > 10)
                {

                }
                //else if
                //{

                //}
            }
            int max = tiengetallen.Max();
            return max;
        }




    }
}
