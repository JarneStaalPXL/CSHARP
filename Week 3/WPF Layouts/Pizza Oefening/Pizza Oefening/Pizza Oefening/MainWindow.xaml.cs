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

namespace Pizza_Oefening
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
        private void VerwerkBestelling(object sender, RoutedEventArgs e)
        {
            int aantalPizzas;
            double totaalprijs = 0;
            string result = "";
            result += $"Naam: {nameLabel.Text}\n";
            result += $"Telefoonnummer: {telLabel.Text}\n";
            result += $"E-mail: {emailLabel.Text}\n";
            result += $"Adres: {adresLabel.Text}\n";
            result += $"Woonplaats: {woonplaatsLabel.Text} - {postcodeLabel.Text}\n";
            result += "\nU heeft de volgende pizza's besteld\n-------------------------\n";

            int.TryParse(quattroStagioniTeller.Text, out aantalPizzas);
            if (aantalPizzas > 0)
            {
                result += $"{aantalPizzas} x €{prijsQuatroStagioni} - Quattro Stagioni\n";
                totaalprijs += aantalPizzas * prijsQuatroStagioni;
            }
            int.TryParse(capricciosaTeller.Text, out aantalPizzas);
            if (aantalPizzas > 0)
            {
                result += $"{aantalPizzas} x €{prijsCapricciosa} - Capricciosa\n";
                totaalprijs += aantalPizzas * prijsCapricciosa;
            }
            int.TryParse(margheritaTeller.Text, out aantalPizzas);
            if (aantalPizzas > 0)
            {
                result += $"{aantalPizzas} x €{prijsMargherita} - Margherita\n";
                totaalprijs += aantalPizzas * prijsMargherita;
            }
            result += $"Totaalbedrag = {totaalprijs}";
            Verwerken.Text = result;

        }
    }
}
