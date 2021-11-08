using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenOefenen.Deel_2
{
    public partial class PartialClass2
    {
        // In dit deel kunnen enkel zelfstandige methoden staan want de eigenschappen van deel 1 worden hier niet herkend!
        public static PartialClass CreateContact(string name, string address)
        {
            return new PartialClass(name, address);
        }
    }
}
