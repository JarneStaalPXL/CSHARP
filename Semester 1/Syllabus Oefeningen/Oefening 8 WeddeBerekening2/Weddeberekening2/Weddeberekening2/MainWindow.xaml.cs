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

namespace Weddeberekening2
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

        private void ButtonBerekenen_Click(object sender, RoutedEventArgs e)
        {
            string naam = personeelslidBox.Text;
            double.TryParse(uurloonBox.Text, out double uurloon);
            double.TryParse(aantalUrenBox.Text, out double aantalUren);

            double brutoJaarWedde = aantalUren * uurloon;

            double nettoJaarWedde = brutoJaarWedde * 0.7;

            resultBox.Text = $"LOONFICHE VAN {naam}" +
                $"\n\nAantal gewerkte uren  :   {aantalUren}" +
                $"\nUurloon:              :   € {uurloon}" +
                $"\nBrutojaarwedde        :   € {brutoJaarWedde.ToString("0 000.00")}" +
                $"\nBelasting             :   € {(brutoJaarWedde - nettoJaarWedde).ToString("0 000.00")}" +
                $"\nNettojaarwedde        :   € {nettoJaarWedde.ToString("0 000.00")}";
        }

        private void ButtonWissen_Click(object sender, RoutedEventArgs e)
        {
            personeelslidBox.Text = "";
            uurloonBox.Text = "";
            aantalUrenBox.Text = "";
            resultBox.Text = "";

            personeelslidBox.Focus();
        }

        private void ButtonAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
