using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasseOvereveringPersoon
{
    public class Lector : Persoon
    {
        public DateTime Indienst { get; set; }
        public string Statuut { get; set; }

        private string afdeling;
        public string Afdeling
        {
            get { return afdeling; }
            set { afdeling = Afdelingsnaam(value); }
        }

        private string Afdelingsnaam(string afd)
        {
            switch (afd)
            {
                case "SNE":
                    return "Systemen en netwerken";
                case "PRO":
                    return "Programmeren";
                case "IOT":
                    return "Internet of Things";
                case "DVG":
                    return "Digitale vormgeving";
                default:
                    return "Onbekende afdeling";

            }
        }

        public override void Info (string tekst)
        {
            //Infotekst is gewijzigd
            string info = "Gegevens van de lector:  ";
            System.Windows.MessageBox.Show(info + tekst, "Info lector", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Information);
        }
        public override string Gegevens => $"{VolledigeNaam()} - " +
            $"{Statuut} - {Afdeling}";
        public string AfdrukIndienst() => $"{VolledigeNaam()}  " +
            $"is in dienst sinds: {Indienst.ToShortDateString()}";
        public string AfdrukAdres() => $"{VolledigeNaam()} {Straat } {Postcode}";

        public override string ToString() => (Statuut == "DT") ? $"Lector is deeltijds actief" : $"Lector is voltijds actief";
    }
}
