using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefening_10_KlassePersoneel
{
    /// <summary>
    /// Interaction logic for KlassePersoneel.xaml
    /// </summary>
    public partial class KlassePersoneel : Window
    {
        private MessageBoxResult result;
        public KlassePersoneel()
        {
            result = MessageBox.Show("Starten met ingevulde waarden?", "Start", MessageBoxButton.YesNo);
            
            InitializeComponent();
        }

        private Personeel ps = new Personeel();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (result == MessageBoxResult.Yes)
            {
                Personeel psa  = new Personeel("Staal", "Jarne", "M", 0, 2001);
                TxtVoornaam.Text = psa.Voornaam;
                TxtNaam.Text = psa.Naam;
                TxtStartjaar.Text = $"{psa.Startjaar}";
                CboGeslacht.Text = psa.Geslacht;
                TxtResultaat.Text = psa.ToonInfo();
            }
            else if (result == MessageBoxResult.No)
            {
                TxtStartjaar.Text = $"{ps.Startjaar}";
                CboGeslacht.SelectedIndex = 0;
            }
        }

        private void BtnVerhoogBeoordeling(object sender, RoutedEventArgs e)
        {
            
            ps.VerhoogBeoordeling();
            TxtResultaat.Text = ps.ToonInfo();
        }

        private void BtnVerlaagBeoordeling(object sender, RoutedEventArgs e)
        {
            
            ps.VerlaagBeoordeling();
            TxtResultaat.Text = ps.ToonInfo();
        }

        private void TxtVoornaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            ps.Voornaam = TxtVoornaam.Text;
            TxtResultaat.Text = ps.ToonInfo();
        }

        private void TxtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            ps.Naam = TxtNaam.Text;
            TxtResultaat.Text = ps.ToonInfo();
        }

        private void TxtStartjaar_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtStartjaar.Text != string.Empty)
            {
                ps.Startjaar = int.Parse(TxtStartjaar.Text);
                TxtResultaat.Text = ps.ToonInfo();
            }
        }

        private void CboGeslacht_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ps.Geslacht = ((ComboBoxItem)
            CboGeslacht.SelectedItem).Content.ToString();
            TxtResultaat.Text = ps.ToonInfo();

        }
    }
}
