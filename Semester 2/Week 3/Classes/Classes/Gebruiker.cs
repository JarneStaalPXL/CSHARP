using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Gebruiker
    {
        //=========================================
        // DECLARATIE VAN INSTANTIEVARIABELEN.
        //=========================================
        private string voornaam;
        private string familienaam;
        //=========================================
        // DEFAULT CONSTRUCTOR ZONDER PARAMETERS
        //=========================================
        public Gebruiker()
        {
            //Initialisatie instantievariabelen. 
            familienaam = string.Empty;
            voornaam = string.Empty;
        }
 
         //=========================================
         // CONSTRUCTOR MET PARAMETERS 
         //=========================================
        public Gebruiker(string name, string familyname)
        {
            familienaam = familyname; // De property Voornaam/Naam krijgt een waarde.
            voornaam = name;
        }
        //=========================================
        // READ AND WRITE EIGENSCHAP VOORNAAM
        //=========================================
        public string Voornaam
        {
            get { return voornaam; } // GetAccessor haalt waarde uit klasse.
            set { voornaam = value; } // SetAccessor ontvangt waarde.
        }
        //=========================================
        // READ AND WRITE EIGENSCHAP NAAM
        //=========================================
        public string Naam
        {
            get { return familienaam; }
            set { familienaam = value; }
        }
        //============================================
        // READ-ONLY EIGENSCHAP GEGEVENS
        // Voegt voornaam en naam in hoofdletter samen 
        //============================================
        public string Gegevens
        {
            get { return voornaam + " " + familienaam.ToUpper(); }
        }
        //============================================
        // FUNCTIEMETHOD TOONNAAM
        // Voegt voornaam en familienaam samen. 
        //============================================
        public string ToonNaam()
        {
            return voornaam + " - " + familienaam;
        }
    }
}
