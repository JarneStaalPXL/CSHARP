using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ClassesPersoneel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private Personeel medwrk = new Personeel();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBoxResult antwoord = MessageBox.Show("Starten met ingevulde waarden?","Start",MessageBoxButton.YesNo);

            if (antwoord == MessageBoxResult.Yes)
            {
                medwrk = new Personeel("Cuppens","Helena","V",7,1993);

                TxtVoornaam.Text = medwrk.Voornaam;
                TxtNaam.Text = medwrk.Naam;
                TxtStartjaar.Text = medwrk.Startjaar.ToString();
                CboGeslacht.Text = medwrk.Geslacht;
                TxtResultaat.Text = medwrk.ToonInfo();
            }
            else
            {
                TxtStartjaar.Text = medwrk.Startjaar.ToString();
                CboGeslacht.Text = medwrk.Geslacht;
            }
        }

        private void TxtVoornaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            medwrk.Voornaam = TxtVoornaam.Text;
            TxtResultaat.Text = medwrk.ToonInfo();
        }

        private void TxtNaam_TextChanged(object sender, TextChangedEventArgs e)
        {
            medwrk.Naam = TxtNaam.Text;
            TxtResultaat.Text = medwrk.ToonInfo();
        }

        private void TxtStartjaar_TextChanged(object sender, TextChangedEventArgs e)
        {
            medwrk.Startjaar = int.Parse(TxtStartjaar.Text);
            TxtResultaat.Text = medwrk.ToonInfo();
        }

        private void CboGeslacht_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            medwrk.Geslacht = ((ComboBoxItem)CboGeslacht.SelectedItem).Content.ToString();
            TxtResultaat.Text = medwrk.ToonInfo();
        }

        private void BtnVerhoog_Click(object sender, RoutedEventArgs e)
        {
            medwrk.VerhoogBeoordeling();
            TxtResultaat.Text = medwrk.ToonInfo();
        }

        private void BtnVerlaag_Click(object sender, RoutedEventArgs e)
        {
            medwrk.VerlaagBeoordeling();
            TxtResultaat.Text = medwrk.ToonInfo();
        }
    }
}
