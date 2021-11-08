using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2
{
    public partial class PartialClass
    {
        // ==== Read-only properties ===
        public string Naam { get; private set; }
        public string Adres { get; private set; }
        // ==== Constructor ==== 
        public PartialClass(string contactNaam, string contactAdres)
        {
            Naam = contactNaam;
            Adres = contactAdres;
        }
    }


}
