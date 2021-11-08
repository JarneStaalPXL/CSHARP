using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_17_ABankrekening
{
    public abstract class Bankrekening
    {
        public float saldo;

        

        public Bankrekening(float opening, string name, string adress)
        {
            saldo = opening;
            Naam = name;
            Adres = adress;

        }

        public string Adres { get; set; }
        public float HuidigSaldo => saldo;
        public string Naam { get; set; }

        public abstract double BerekenRente();

        public virtual void CreditSaldo(float value)
        {
            saldo += value;
        }

        public virtual void DebetSaldo(float value)
        {
            saldo -= value;
        }
    }
}
