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

namespace VerwachteLengte
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

        private void boyChecked(object sender, RoutedEventArgs e)
        {
            txtMeisje.IsEnabled = false;
            txtJongen.IsEnabled = true;
            txtMeisje.Text = "";
            girlRadio.IsChecked = false;
        }

        private void girlChecked(object sender, RoutedEventArgs e)
        {
            txtJongen.IsEnabled = false;
            txtMeisje.IsEnabled = true;
            txtJongen.Text = "";
            boyRadio.IsChecked = false;
        }

        private void Berekenen_Click(object sender, RoutedEventArgs e)
        {
            double.TryParse(txtVader.Text, out double lengteVader);
            double.TryParse(txtMoeder.Text, out double lengteMoeder);

            if (boyRadio.IsChecked == true)
            {
                double lengteJongen = (lengteVader + lengteMoeder + 13) / 2 + 4.5;
                txtJongen.Text = lengteJongen.ToString();

            }
            else if (girlRadio.IsChecked == true)
            {
                double lengteMeisje = (lengteVader + lengteMoeder - 13) / 2 + 4.5;
                txtMeisje.Text = lengteMeisje.ToString();
            }
            

        }
    }
}
