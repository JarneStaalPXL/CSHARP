using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2
{
    public class Gebruiker
    {
        public string Gegevens { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        public Gebruiker()
        {
                
        }
        public Gebruiker(string name, string familyname)
        {
            Naam = familyname;
            Voornaam = name;
        }

        public string ToonNaam() => Voornaam + "-" + Naam ;

    }
}
