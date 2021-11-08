using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_19_IList
{
    public class ListModule : IModules
    {
        public int aantal;
        public static List<string> Listmodules = new List<string>();

        public void Add(string text, ListBox lbx)
        {
            Listmodules.Add(text);
            lbx.Items.Add(text);
        }

        public void IndexOf(string moduleInput)
        {
            int index = Listmodules.FindIndex(a => a.Contains(moduleInput));
            MessageBox.Show($"The index of this word is: {index}",moduleInput, (MessageBoxButton)MessageBoxImage.Information, (MessageBoxImage)MessageBoxButton.OK);
        }

        public void Remove(string selectedItem, ListBox lbx)
        {
            Listmodules.Remove(selectedItem);
            lbx.Items.Remove(selectedItem);
        }
    }
}
