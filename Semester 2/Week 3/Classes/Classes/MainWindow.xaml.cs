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

namespace Classes
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

        private void BtnConLeeg_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gb = new Gebruiker()
            {
                Voornaam = TxtVoornaam.Text,
                Naam = TxtNaam.Text
            };

            TxtResultaat.Text = $"Voornaam: {gb.Voornaam}\n";
            TxtResultaat.Text += $"Gegevens: {gb.Gegevens}";
            TxtResultaat.Text += $"\n\nNaam van gebruiker: {gb.ToonNaam()}";
        }

        private void BtnConParam(object sender, RoutedEventArgs e)
        {
            Gebruiker naam = new Gebruiker("Kristof","Palmaers");

            TxtResultaat.Text = $"Voornaam: {naam.Voornaam}\n";
            TxtResultaat.Text += $"Gegevens: {naam.Gegevens}";
            TxtResultaat.Text += $"\n\nNaam van gebruiker: {naam.ToonNaam()}";
        }

        private void BtnPersoon_Click(object sender, RoutedEventArgs e)
        {
            Persoon prsoon = new Persoon();
            TxtResultaat.Text = $"Naam: {prsoon.Naam}\n" +
                $"{prsoon.ToonNaam()}";

            prsoon = new Persoon("Paul","Dox");
            TxtResultaat.Text += $"\n\nNaam: {prsoon.Naam}\n{prsoon.ToonNaam()}";
        }

        private void BtnVerjaardag_Click(object sender, RoutedEventArgs e)
        {
            // Constructor zonder parameters
            Verjaardag vj = new Verjaardag();
            vj.IsFeest = false;
            //vj.AantalCadeaus = 5;
            vj.MijnBoodschap = " Kristof";
            MessageBox.Show(vj.MijnBoodschap, "Verjaardagsfeest?");
            // === of ===
            // Constructor met parameters
            Verjaardag vjp = new Verjaardag(TxtVoornaam.Text, DateTime.Parse("1980-03-16"));
            MessageBox.Show(vjp.MijnBoodschap, TxtVoornaam.Text + " " + TxtNaam.Text);
        }
    }
}
