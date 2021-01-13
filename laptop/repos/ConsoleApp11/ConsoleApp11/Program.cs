using System;
using System.Text;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            string b = "number";

            StringBuilder sb = new StringBuilder();

            sb.Append('-', 6);
            sb.Append(" Test2 ");
            sb.Append('-', 6);

            sb.Append("\n"+a+" " +b);

            Console.WriteLine(sb);


        }
    }
}
