using System;

namespace mish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("U kunt drie parameters ingeven of het goed weer is om te wandelen");
            Console.WriteLine("dit zijn de parameters die u kunt ingeven:");

            Console.WriteLine("temperatuur: warm, koud");
            string input = Console.ReadLine().ToLower();
            Console.WriteLine("wind: windstil, bries");
            string input2 = Console.ReadLine().ToLower();
            Console.WriteLine("regen: geen regen, regen");
            string input3 = Console.ReadLine().ToLower();

            if ("warm".Contains(input) && "windstil".Contains(input2) && "geen regen".Contains(input3))
            {
                   Console.WriteLine("Het is goed weer om te wandelen");
            }
            else if ("warm".Contains(input) && "windstil".Contains(input2) && "regen".Contains(input3))
            {
                Console.WriteLine("Lekker binnen blijven");
            }
            else if ("warm".Contains(input) && "bries".Contains(input2) && "geen regen".Contains(input3))
            {
                Console.WriteLine("Het is goed weer om te wandelen");
            }
            else if ("warm".Contains(input) && "bries".Contains(input2) && "regen".Contains(input3))
            {
                Console.WriteLine("Lekker binnen blijven");
            }
            else if ("koud".Contains(input) && "windstil".Contains(input2) && "geen regen".Contains(input3))
            {
                Console.WriteLine("Het is goed weer om te wandelen");
            }
            else if ("koud".Contains(input) && "windstil".Contains(input2) && "regen".Contains(input3))
            {
                Console.WriteLine("Lekker binnen blijven");
            }
            else if ("koud".Contains(input) && "bries".Contains(input2) && "geen regen".Contains(input3))
            {
                Console.WriteLine("Het is goed weer om te wandelen");
            }
            else if ("koud".Contains(input) && "bries".Contains(input2) && "regen".Contains(input3))
            {
                Console.WriteLine("Lekker binnen blijven");
            }


            //Console.WriteLine("temperatuur: warm, koud");
            //string temperatuur = Console.ReadLine();
            //string warm;
            //string koud;

            //Console.WriteLine("wind: windstil, bries");
            //string wind = Console.ReadLine();
            //string windstil;
            //string bries;

            //Console.WriteLine("regen: geen regen, regen");
            //string neerslag = Console.ReadLine();
            //string regen;
            //string geenregen;



            //if (false)
            //{
            //    Console.WriteLine("Het is goed weer om te wandelen");
            //}

            //else
            //{
            //    Console.WriteLine("Blijf lekker binnen");
            //}
        }
    }
}
