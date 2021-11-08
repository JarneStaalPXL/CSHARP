using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_19_IList
{
    public interface IModules
    {
        void Add(string text, ListBox lbx);

        void IndexOf(string moduleInput);

        void Remove(string selectedItem, ListBox lbx);
    }
}
