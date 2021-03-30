using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KlasseOvereveringPersoon
{
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Naam { get; set; }
        public string Straat { get; set; }
        public string Postcode { get; set; }
        public DateTime Geboortedatum { get; set; }
        public string Email { get; set; }


        // Read-Only Properties
        public virtual string Gegevens => $"{VolledigeNaam()}\nGeboortedatum: {Geboortedatum.ToLongDateString()}";

        // void method
        public virtual void Info(string tekst)
        {
            tekst = $"Naam: {Voornaam} {Naam}\nAdres: {Straat} {Postcode}\nGeboortedatum: {Geboortedatum}" +
                $"\nEmail: {Email}";
            string info = $"Uw persoonlijke gegevens: \n\n";
            MessageBox.Show(info + tekst, "Info Klasse Persoon", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        public virtual string VolledigeNaam() => Voornaam + " " + Naam;

        public Persoon()
        {
            Voornaam = "Patricia";
            Naam = "Briers";
            Straat = "Elfde-Liniestraat 26";
            Postcode = "3500";
            Geboortedatum = DateTime.Parse("1988-10-3");
        }
    }
}
