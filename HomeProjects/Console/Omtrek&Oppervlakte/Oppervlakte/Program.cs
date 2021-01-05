using System;

namespace Oppervlakte
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Van wat wil je de omtrek?");
                Console.Write("\nDruk 1 voor");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Driehoek");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nDruk 2 voor");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(" Vierkant");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\nDruk ENTER om het te bevestigen.");
                Console.ForegroundColor = ConsoleColor.White;

                int answer = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (answer)
                {
                    
                    case 1:
                        Console.Write("Geef de lengte in cm: ");
                        double lengteDriehoek = double.Parse(Console.ReadLine());
                        Console.Write("Geef de breedte in cm: ");
                        double breedteDriehoek = double.Parse(Console.ReadLine());
                        Console.Write("Geef de hoogte in cm: ");
                        double hoogteDriehoek = double.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Green;
                        double omtrekDriehoek = lengteDriehoek + breedteDriehoek + hoogteDriehoek;
                        Console.WriteLine($"Lengte driehoek: {lengteDriehoek}cm \nBreedte driehoek: {breedteDriehoek}cm \nHoogte driekhoek: {hoogteDriehoek}cm" +
                            $"\n\nHeeft als omtrek {omtrekDriehoek}cm"
                            );

                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Deze is momenteel onbeschikbaar");
                        break;
                }

                Console.WriteLine("\n\nDRUK ENTER OM OPNIEUW TE BEGINNEN");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
