using System;

namespace Oefening_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Input num?");
            int Input = Convert.ToInt32(Console.ReadLine());

            int StartGetal = Input * Input;

            string uitvoer ="";

            for (int i = 0; i < 20; i++)
            {
                //kolommen
                for (int j = 0; j < Input; j++)
                {
                    uitvoer += StartGetal + "  ";
                    StartGetal--;
                }
                uitvoer += "\n";
            }
            Console.WriteLine(uitvoer);
            Console.ReadLine();
        }
    }
}   