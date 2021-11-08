using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2.Inheritance
{
    public class Werknemer : Persoon
    {
        public string functie = "";
        public DateTime DatumInDienst { get; set; }

        public string Functie 
        { 
            get { return functie; } 
            set { functie = value; } 
        }

        public override string Gegevens => $"{base.Gegevens} - {Functie}";

        public override string Lol => $"Naam {base.Naam}";

        public void Info() { }
    }
}
