using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefening_7_KlasseBankRekening
{
    public class Bankrekening
    {
        public static float HuidigSaldo { get; set; }

        public void BankRekening(float amount)
        {
            if (amount < 0)
            {
                BedragVerminderen(amount);
            }
            else
            {
                BedragVerhogen(amount);
            }
        }

        public void BedragVerhogen(float amount)
        {
            HuidigSaldo = HuidigSaldo + amount;
        }

        public void BedragVerminderen(float amount)
        {
            HuidigSaldo = HuidigSaldo + amount;
        }
    }
}
