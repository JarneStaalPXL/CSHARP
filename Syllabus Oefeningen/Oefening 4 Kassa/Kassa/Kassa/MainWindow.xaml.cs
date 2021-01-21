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

namespace Kassa
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
            double.TryParse(prijsBox.Text, out double prijs);
            double.TryParse(aantalBox.Text, out double aantal);

            resultLbl.Content = (prijs * aantal).ToString();

        }

        private void Controle_Nummer_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(btwNrBox1.Text, out double btwNr1);

            double result = btwNr1 / 97;
            double result2 = Convert.ToInt32(97 - result);


            var mod = btwNr1 % 97;
            double resulto = 97 - mod;

            //double resultaat = 97 - (btwNr1 - (btwNr1 / 97) * 97);
            btwNrBox2.Text = (resulto).ToString();


            

        }

        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
