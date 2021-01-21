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

namespace Reiskost
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

        private void Berekenen_Click(object sender, RoutedEventArgs e)
        {
            string bestemming = bestemmingBox.Text;
            double.TryParse(basisVluchtBox.Text, out double basisVlucht);
            double.TryParse(vluchtKlasseBox.Text, out double vluchtKlasse);
            double.TryParse(basisPrijsPerDagBox.Text, out double basisPrijsPerDag);
            double.TryParse(aantalDagenBox.Text, out double aantalDagen);
            double.TryParse(aantalPersonenBox.Text, out double aantalPersonen);
            double.TryParse(kortingsPercentageBox.Text, out double kortingsPercentage);

            double vluchtprijs = (basisVlucht * aantalPersonen);
            double verblijfsprijs = (basisPrijsPerDag * (aantalDagen * aantalPersonen));
            double reisprijs = vluchtprijs + verblijfsprijs;
            double totaalprijs = (vluchtprijs + verblijfsprijs);

            double procentVanTotaalPrijs = (totaalprijs * 5) /100;
            double korting = reisprijs -( totaalprijs - procentVanTotaalPrijs) ;
            double teBetalen = reisprijs - korting;


            result.Text = $"REISKOST VOLGENS BESTELLING NAAR {bestemming}" +
                $"\n\nTotale vluchtprijs: € {vluchtprijs.ToString("000.00")}" +
                $"\nTotale verblijfprijs: € {verblijfsprijs.ToString("0 000.00")}" +
                $"\nTotale reisprijs: € {reisprijs.ToString("0 000.00")}" +
                $"\nKorting: € {korting.ToString("000.00")}"+
                $"\n\n Te betalen: € {teBetalen.ToString("0 000.00")}";

        }

        private void Wissen_Click(object sender, RoutedEventArgs e)
        {
            bestemmingBox.Text = "";
            basisVluchtBox.Text = "";
            vluchtKlasseBox.Text = "";
            basisPrijsPerDagBox.Text = "";
            aantalDagenBox.Text = "";
            aantalPersonenBox.Text = "";
            kortingsPercentageBox.Text = "";
            result.Text = "";

        }


        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void vluchtKlasseEnter(object sender, MouseEventArgs e)
        {
            infoLbl.Visibility = Visibility.Visible;
        }

        private void vluchtKlasseLeave(object sender, MouseEventArgs e)
        {
            infoLbl.Visibility = Visibility.Hidden;
        }
    }
}
