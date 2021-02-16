using System;

namespace TestInfo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What is your phone number?");
            string phonenr = Console.ReadLine();
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();

            Console.WriteLine("Your Name is:" + name);
            Console.WriteLine("Your Age is:" + age);
            Console.WriteLine("Your PhoneNR is:" + phonenr);
            Console.WriteLine("Your Email is:" + email);
        }
    }
}
