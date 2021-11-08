using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_17_ABankrekening
{
    public class Zichtrekening : Bankrekening
    {
        public Zichtrekening(float opening, string name, string adress) 
            : base(opening, name, adress)
        {

        }
        public override double BerekenRente()
        {
            return HuidigSaldo * 0.005f;
        }

        public override void CreditSaldo(float value)
        {
            if ((HuidigSaldo + value) < 0 )
            {
                throw new BankException("Zichtrekening: saldo ontoereikend");
            }
            base.CreditSaldo(value);
        }
    }
}
