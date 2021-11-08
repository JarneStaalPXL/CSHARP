using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_17_ABankrekening
{
    public class Spaarrekening : Bankrekening
    {
        public Spaarrekening(float opening, string name, string adress) 
            : base(opening, name, adress)
        {

        }
        public override double BerekenRente()
        {
            return saldo * 0.015 - 100;
        }
    }
}
