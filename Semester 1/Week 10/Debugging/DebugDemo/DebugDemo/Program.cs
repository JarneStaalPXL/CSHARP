using System;
using System.Collections.Generic;

namespace DebugDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // maken van lijst
            List<string> woorden = new List<string>() { "test", "hallo", "hoera", "c sharp best sharp" };
            // maak een array
            string[] woordenArray = new string[4] { "test", "hallo", "hoera", "c sharp best sharp" };
            // afprinten van list
            foreach (string item in woorden)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("De lengte van de lijst is = " + woorden.Count);
            // afprinten van array
            foreach (string item in woordenArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("De lengte van de array is = " + woordenArray.Length);
            // Do something
            DoSomething(woorden);
            DoSomethingMaarVoorArray(woordenArray);
            // afprinten 
            foreach (string item in woorden)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("De lengte van de lijst is = " + woorden.Count);
            // afprinten
            foreach (string item in woordenArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("De lengte van de array is = " + woordenArray.Length);
        }
        private static void DoSomething(List<string> mijnLijst)
        {
            mijnLijst.Clear();
        }
        private static void DoSomethingMaarVoorArray(string[] mijnRij)
        {

        }
    }
}
