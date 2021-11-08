using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace ExamenOefenen.Oefeningenbundel.Oefening_8_KlasseTeller
{
    public class Teller
    {
        public static int Counter { get; set; }

        public void ResetTeller()
        {
            Counter = 0;
        }

        public void VerhoogTeller()
        {
            Counter++;
        }

        public void VerminderTeller()
        {
            Counter--;
        }

        public void Waarde(int amount)
        {
            Counter = Counter + amount;
        }


    }
}
