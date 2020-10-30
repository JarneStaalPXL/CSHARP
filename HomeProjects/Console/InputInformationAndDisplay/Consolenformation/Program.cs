using System;

namespace Consolenformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your Age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Are you a man? True of false");
            Boolean isMan = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("What is your Phone number?");
            int phonenr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your Email?");
            string email = Console.ReadLine();
            Console.WriteLine("What is your Postal code?");
            int postal = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is your Town name?");
            string town = Console.ReadLine();

            Console.WriteLine("\n");

            Console.WriteLine("Name = " + name);
            Console.WriteLine("Age = " + age);
            Console.WriteLine("isMan = " + isMan);
            Console.WriteLine("Phone Number = " + phonenr);
            Console.WriteLine("Email = " + email);
            Console.WriteLine("Postal Code = " + postal);
            Console.WriteLine("Town Name = " + town);
        }
    }
}
