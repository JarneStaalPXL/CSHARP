using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPersoneel
{
    public class Personeel
    {

        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Geslacht { get; set; }
        public int Startjaar { get; set; }




        public int cijfer;

        public int Beoordelingscijfer
        {
            get
            {
                if (cijfer < 0)
                { return 0; }
                else if (cijfer > 10)
                { return 10; }
                else
                { return cijfer; }
            }
            set { cijfer = value; }
        }




        public int Dienstjaren => DateTime.Today.Year - Startjaar;

        public string GeslachtTekst => (Geslacht == "V") ? "Mannelijk" : "Vrouwelijk";

        public float Premie => BerekenPremie();

        private float BerekenPremie()
        {
            float premie = 500 + (20 * Dienstjaren);
            if (Beoordelingscijfer < 5)
            {
                premie /= 2;
            }
            else if (Beoordelingscijfer == 7 || Beoordelingscijfer == 8)
            {
                premie *= 1.5f;
            }
            else if (Beoordelingscijfer == 9 || Beoordelingscijfer == 10)
            {
                premie *= 2f;
            }
            return premie;
        }

        public void VerhoogBeoordeling()
        {
            Beoordelingscijfer++;
        }

        public void VerlaagBeoordeling()
        {
            Beoordelingscijfer--;
        }

        public string ToonInfo()
        {
            return $"Personeelslid  {Voornaam} {Naam}" +
                $"\n\nGeslacht : {GeslachtTekst}" +
                  $"\nAantal dienstjaren : {Dienstjaren}" +
                  $"\nBeoordelingscijfer : {Beoordelingscijfer}" +
                  $"\nPremie {Premie:c}  ";
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


    }
}
