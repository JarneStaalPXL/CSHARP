using System;
using System.IO;

namespace Tekstbestanden
{
    class Program
    {
        static void Main(string[] args)
        {
            // SCHRIJVEN
            // Tekstbestand creëren en openen (automatisch in standaardirectory van je project \bin\Debug).
            StreamWriter sw = new StreamWriter("TestBestand.Txt");
            // Naar tekstbestand schrijven.
            sw.WriteLine("Volgorde van getallen :"); 
            for (int i = 0; i < 10; i++) 
            sw.Write(i + " ");
            sw.WriteLine(); // lege regel wegschrijven
                            // Sluiten van bestand.
            sw.Close();
        }
    }
}
