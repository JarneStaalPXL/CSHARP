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

namespace WeddeBerekening
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
            string naam = personeelslidBox.Text;
            double.TryParse(uurloonBox.Text, out double uurloon);
            double.TryParse(aantalUrenBox.Text, out double aantalUren);


            double brutoJaarWedde = aantalUren * uurloon;

            if (brutoJaarWedde >= 50000)
            {
                double nettoJaarWedde = brutoJaarWedde * 0.5;
            }
            else if (brutoJaarWedde >= 25000)
            {
                double nettoJaarWedde = brutoJaarWedde * 0.6;
            }
            else if (brutoJaarWedde >= 15000)
            {
                double nettoJaarWedde = brutoJaarWedde * 0.7;
            }
            else if (brutoJaarWedde >= 10000)
            {
                double nettoJaarWedde = brutoJaarWedde * 0.8;
            }
            double resultaatBelasting = brutoJaarWedde + nettoJaarWedde;

            resultBox.Text = $"LOONFICHE VAN {naam}" +
                $"\n\nAantal gewerkte uren: {aantalUren}" + 
                $"\nUurloon: € {uurloon}" +
                $"\nBrutojaarwedde: € {brutoJaarWedde.ToString("0 000.00")}" +
                $"\nBelasting: € {(resultaatBelasting).ToString("0 000.00")}" +
                $"\nNettojaarwedde : € {nettoJaarWedde.ToString("0 000.00")}";
        }


        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void Wissen_Click(object sender, RoutedEventArgs e)
        {
            personeelslidBox.Text = "";
            uurloonBox.Text = "";
            aantalUrenBox.Text = "";
            resultBox.Text = "";

            personeelslidBox.Focus();
        }

    }
}
