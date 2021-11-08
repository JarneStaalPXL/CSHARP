using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_11_KlasseHuis
{
    public class Huis
    {
        public string Locatie { get; set; }
        public double Lengte { get; set; }
        public double Breedte { get; set; }

        private int aantalverdieping;
        public int AantalVerdieping {
            get 
            {
                if (aantalverdieping >= 1)
                    return aantalverdieping;
                else
                    return 0;
            }
            set
            {
                aantalverdieping = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                if (type == "O")
                    return "Open bebouwing";
                else if (type == "H")
                    return "Half-open bebouwing";
                else 
                    return "Gesloten bebouwing";
            }
            set
            {
                type = value;
            }
        }

        public Huis()
        {
            Locatie = "";
            Lengte = 0;
            Breedte = 0;
            AantalVerdieping = 1;
            Type = "O";
        }

        public Huis(string locatie, double lengte, double breedte, int aantalVerdieping, string type)
        {
            Locatie = locatie;
            Lengte = lengte;
            Breedte = breedte;
            AantalVerdieping = aantalVerdieping;
            Type = type;
        }

        public void VerhoogAantalVerdiepingen()
        {
            AantalVerdieping++;
        }

        public void VerhoogVerdiepingenParam(int getal)
        {
            AantalVerdieping += getal;
        }

        public void VerlaagAantalVerdiepingen()
        {
            if (AantalVerdieping > 1)
            {
                AantalVerdieping--;
            }
        }

        public double Oppervlakte() => Lengte * Breedte;

        public double Inhoud() => Oppervlakte() * (AantalVerdieping * 2.5);

            
    }
}
