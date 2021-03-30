using System;
using System.IO;

namespace Oefening_3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOngeldig = false;
            string result = "";


            Console.WriteLine("What's your First name?");
            string fname = Console.ReadLine(); ;

            Console.WriteLine("What's your Last name?");
            string lname = Console.ReadLine();

            Console.Write("What's your age? ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                isOngeldig = true;
            }
            

            
            if (isOngeldig == true)
            {
                result = fname + "-" + lname + "-" + "Ongeldig";
            }
            else if (isOngeldig == false)
            {
                result = fname + "-" + lname + "-" + age;
            }

            

            using (StreamWriter sw = new StreamWriter("mensen.txt", true))
            {
                sw.WriteLine(result);
            }
        }
    }
}
