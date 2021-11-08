using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2.Inheritance
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        public virtual string VolledigeNaam() => Voornaam + " " + Naam;
        public virtual string Gegevens => $"{Voornaam} {Naam}\r\n";

        public virtual string Lol => $"{Naam}";
    }
}
