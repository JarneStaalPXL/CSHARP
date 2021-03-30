using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KlasseOvereveringPersoon
{
    public class Student : Persoon
    {
        public DateTime Startdatum { get; set; }
        public char Betaald { get; set; }
        public string TypeStudent { get; set; }
        public string Opleiding { get; set; }



        private int studiepunten;
        public int Studiepunten
        {
            get
            {
                return studiepunten;
            }
            set
            {
                studiepunten = value;

                if (studiepunten <0)
                {
                    studiepunten = 0;
                }
                else if (studiepunten > 99)
                {
                    studiepunten = 99;
                }
            }
        }


        //Read-only property.
        private float inschrijvingsbedrag;
        public float Inschrijvingsbedrag
        {
            get
            {
                inschrijvingsbedrag = 520;
                if (TypeStudent == "I")
                {
                    inschrijvingsbedrag = 50 + (8.666667f * studiepunten);
                }
                return inschrijvingsbedrag;
            }
        }

        public override void Info(string tekst)
        {
            // Infotekst is gewijzigd.
            string info = "Gegevens van de student:    ";
            MessageBox.Show(info + tekst,"Info student",MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public override string Gegevens => $"{VolledigeNaam()} - {TypeStudent} - " +
            $"{Betaald} - {Inschrijvingsbedrag:c}";

        public string AfdrukStartdatum() => $"{VolledigeNaam()}  | {Startdatum}";
        public string AfdrukAdres() => $"{VolledigeNaam()} {Straat} {Postcode}";

        //Eigen ToString-methode();c

        public override string ToString() => ((TypeStudent == "I") ? 
            $"Student met individueel traject: " + $"{Studiepunten} SP" 
            : $"Standaardstudent: 60 SP") + $"- Inschrijvingsgeld: {Inschrijvingsbedrag:c} : Betaald: {Betaald:c}";
        

        public Student()
        {
            Startdatum = DateTime.Now;
        }
    }
}
