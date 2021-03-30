using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        public string ToonNaam() => $"Persoon = {Voornaam} {Naam.ToUpper()}";

        public Persoon()
        {
            Naam = "onbekend";
        }

        public Persoon(string firstname, string name)
        {
            Naam = name;
            Voornaam = firstname;
        }
    }
}
