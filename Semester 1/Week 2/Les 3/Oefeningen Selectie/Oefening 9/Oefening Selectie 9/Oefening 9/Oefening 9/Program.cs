using System;

namespace Oefening_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input nummer");
            string oef9Num1 = Console.ReadLine();


            if (sbyte.TryParse(oef9Num1, out sbyte resultSbyte))
            {
                //sbyte
                Console.WriteLine($"Het kleinste data type van {resultSbyte} is een sbyte");
            }
            else if (byte.TryParse(oef9Num1, out byte resultByte))
            {
                //byte
                Console.WriteLine($"Het kleinste data type van {resultByte} is een byte");
            }
            else if (short.TryParse(oef9Num1, out short resultShort))
            {
                //short
                Console.WriteLine($"Het kleinste data type van {resultShort} is een short");
            }
            else if (ushort.TryParse(oef9Num1, out ushort resultUshort))
            {
                //ushort
                Console.WriteLine($"Het kleinste data type van {resultUshort} is een ushort");
            }
            else if (int.TryParse(oef9Num1, out int resultInt))
            {
                //int
                Console.WriteLine($"Het kleinste data type van {resultInt} is een int");
            }
            else if (uint.TryParse(oef9Num1, out uint resultUint))
            {
                //uint
                Console.WriteLine($"Het kleinste data type van {resultInt} is een uint");
            }
            else if (long.TryParse(oef9Num1, out long resultLong))
            {
                Console.WriteLine($"Het kleinste data type van {resultLong} is een long");
            }
            else if (ulong.TryParse(oef9Num1, out ulong resultUlong))
            {
                Console.WriteLine($"Het kleinste data type van {resultUlong} is een ulong");
            }
        }
    }
}
