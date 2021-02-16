using System;

namespace Oefening_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Oefening 5:");
            Console.WriteLine("Schrijf een programma dat twee getallen opvraagt en alle natuurlijke getallen er");
            Console.WriteLine("tussen afdrukt. Indien het eindgetal kleiner is dan het startgetal, dan waarschuwt");
            Console.WriteLine("het programma dat de gebruiker ongeldige input gegeven heeft.");
            Console.WriteLine();

            int firstNum, SecondNum;
            while (true)
            {
                Console.WriteLine("input startgetal");
                if (int.TryParse(Console.ReadLine(), out firstNum))
                {
                    break;
                }
                Console.WriteLine("Please enter an integer value!");
            }

            while (true)
            {
                Console.WriteLine("input eindgetal");
                if (int.TryParse(Console.ReadLine(), out SecondNum) && SecondNum > firstNum)
                {
                    break;
                }
                Console.WriteLine("Kijk na of je een getal hebt ingedukt en of dat het wel groter is dan je eerste nummer");
            }

            for (int i = firstNum; i < SecondNum; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
