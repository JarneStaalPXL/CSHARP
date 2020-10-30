using System;

namespace Oefening_6
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Number 1");
                int num1 = Convert.ToInt32(Console.ReadLine());
    
                Console.WriteLine("Number 2");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("The outcome is " + (num1 * num2));

                Console.WriteLine("Wanna try try? Y/N");
                string answer = Console.ReadLine();

                if (answer .ToLower() == "n") 
                {
                    break;
                }
            }
        }
    }
}
