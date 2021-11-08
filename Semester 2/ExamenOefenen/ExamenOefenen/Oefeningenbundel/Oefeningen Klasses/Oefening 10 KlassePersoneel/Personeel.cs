using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefening_10_KlassePersoneel
{
    public class Personeel
    {
        private static int cijfer;

        public int Startjaar { get; set; }
        public int Dienstjaren => DateTime.Today.Year - Startjaar;

        public static int Beoordelingscijfer
        {
            get // geeft terug
            {
                if (cijfer < 0)
                { return 0; }
                else if (cijfer > 10)
                { return 10; }
                else
                { return cijfer; }
            }
            set { cijfer = value; } // ontvangt
        }
      
        public string Geslacht { get; set; }
        public string GeslachtTekst
        {
            get 
            {
                if (Geslacht == "V")
                {
                    return "Vrouwelijk";
                }
                else return "Mannelijk";
            }
            set { GeslachtTekst = value; }
        }
        public string Naam { get; set; }
        public float Premie => BerekenPremie();
        
        public string Voornaam { get; set; }


        private float BerekenPremie()
        {
            float premie = 500 + (20 * Dienstjaren);
            if (Beoordelingscijfer < 5) { premie /= 2; }
            // bij 5 en 6 blijft premie onveranderd
            else if (Beoordelingscijfer == 7 || Beoordelingscijfer == 8)
            { premie *= 1.5f; }
            else if (Beoordelingscijfer == 9 || Beoordelingscijfer == 10)
            { premie *= 2f; }
            return premie;
        }

        public Personeel()
        {
            Startjaar = DateTime.Today.Year;
            Geslacht = "M";
        }

        public Personeel(string familyname, string firstName, string gender, int rated, int startingYear)
        {
            Naam = familyname;
            Voornaam = firstName;
            Geslacht = gender;
            Beoordelingscijfer = rated;
            Startjaar = startingYear;
        }

        public string ToonInfo()
        {
            return $"Personeelslid {Voornaam, 40} {Naam}" +
            $"\r\n\r\nGeslacht : {GeslachtTekst,40}" +
            $"\r\nAantal dienstjaren : {Dienstjaren,40}" +
            $"\r\nBeoordelingscijfer : {Beoordelingscijfer,40}" +
            $"\r\nPremie: {Premie,40:c}";
        }

        public void VerhoogBeoordeling()
        {
            Beoordelingscijfer++;
        }

        public void VerlaagBeoordeling()
        {
            Beoordelingscijfer--;
        }
    }
}
