using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string username = Console.ReadLine();
            Console.WriteLine("Your Username:" + username);

            Console.WriteLine("Enter Gender");
            string gender = Console.ReadLine();
            Console.WriteLine("Your Gender is:" + gender);
        }
    }
}
