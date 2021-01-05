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

namespace Bioscoop
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
            double normaalTarief = 9.10;
            double kortingsTarief = 8.10;
            double studentenTarief = 6.90;

            double.TryParse(normaalTrfBox.Text, out double normaalTariefResultaat);
            double.TryParse(kortingTrfBox.Text, out double kortingsTariefResultaat);
            double.TryParse(studentTrfBox.Text, out double studentenTariefResultaat);

            double resultaatNormaalTarief = (normaalTariefResultaat * normaalTarief);
            double resultaatKortingsTarief = (kortingsTariefResultaat * kortingsTarief);
            double resultaatStudentenTarief = (studentenTariefResultaat * studentenTarief);

            prijsLbl.Content = (resultaatNormaalTarief + resultaatKortingsTarief + resultaatStudentenTarief).ToString() ;
        }

        private void Wissen_Click(object sender, RoutedEventArgs e)
        {
            normaalTrfBox.Text = "";
            kortingTrfBox.Text = "";
            studentTrfBox.Text = "";
        }

        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
