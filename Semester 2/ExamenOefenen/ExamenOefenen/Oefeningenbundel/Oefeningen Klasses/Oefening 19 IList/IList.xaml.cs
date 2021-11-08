using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_19_IList
{
    /// <summary>
    /// Interaction logic for IList.xaml
    /// </summary>
    public partial class IList : Window 
    {
        public IList()
        {
            InitializeComponent();
        }

        private IModules md = new ListModule();
        private ListModule lm = new ListModule();
        private void Toevoegen_Click(object sender, RoutedEventArgs e)
        {
            md.Add(moduleInput.Text, lbxModules);
        }

        private void Zoeken_Click(object sender, RoutedEventArgs e)
        {
            md.IndexOf(moduleInput.Text);
        }


        private void Verwijderen_Click(object sender, RoutedEventArgs e)
        {
            md.Remove(lbxModules.SelectedItem.ToString(), lbxModules);
        }
    }
}
