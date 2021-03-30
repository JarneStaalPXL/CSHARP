using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Verjaardag
    {

        // ==== Klassevariabelen ====
        private int maand;
        private string boodschap, naam;

        // ==== READ AND WRITE PROPERTY ====
        public int AantalCadeaus { get; set; }
        public bool IsFeest { get; set; }

        public string MijnBoodschap
        {
            get { return boodschap; }
            set { boodschap = GeeftBericht(value); }
        }

        // ==== PRIVATE FUNCTION ====
        private string GeeftBericht(string persoon)
        {
            string bericht;

            if (IsFeest)
            {
                bericht = $"Gelukkige verjaardag! {persoon}\r\n" +
                    $"Aantal cadeaus ={ AantalCadeaus}\r\n" +
                    $"Geniet van het verjaardagsfeestje!";
            }
            else
            {
                bericht = $"Jammer {persoon} geen verjaardagsfeest!";
            }
            return bericht;
        }
        
        // ==== CONSTRUCTOR ZONDER PARAMETERS ====
        public Verjaardag()
        { AantalCadeaus = 1; }
        // ==== CONSTRUCTOR MET PARAMETERS ====
        public Verjaardag(string name, DateTime birthday)
        {
            naam = name;
            maand = birthday.Month;
            AantalCadeaus = 5;
            if (maand == DateTime.Today.Month) IsFeest = true;
            MijnBoodschap = naam;
        }   
    }
}
