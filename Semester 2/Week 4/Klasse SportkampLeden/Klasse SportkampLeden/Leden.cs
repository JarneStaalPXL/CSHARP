using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasse_SportkampLeden
{
    public class Leden
    {
        public static string[,] kampen = Sportkampen.InlezenKamp();
        public int kampnr;

        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public int Weeknr { get; set; }
        public float KampVolgnr { get; set; }

        private string kampcode;
        public string Kampcode
        {
            get
            {
                return kampcode;
            }
            set
            {
                kampcode = value;
                for (int i = 0; i <= kampen.GetUpperBound(0); i++)
                {
                    if (kampcode == kampen[i, 0]) 
                    {
                        kampnr = i; 
                    }
                }
            }
        }


        public string NaamVolledig => $"{Voornaam} {Naam}";
        public string SportNaam => kampen[kampnr, 1];
        public float Kampprijs => float.Parse(kampen[kampnr, 2]);

        public float TeBetalen
        {
            get
            {
                if (KampVolgnr >= 5)
                {
                    return Kampprijs * 0.9f;
                }
                else if (KampVolgnr >= 2)
                {
                    return Kampprijs * 0.95f;
                }
                else return Kampprijs;
            }
        }

        public string InformatieVolledig() => $"{NaamVolledig,-25}{SportNaam,-15}" +
            $"{Kampprijs} - {KampVolgnr} - {TeBetalen:c}";

    }
}
