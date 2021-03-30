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
using System.Windows.Threading;

namespace Oefening_21_PlusMaalTafel
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
        // Installeren van timer.
        private DispatcherTimer klokje = new DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            // Timer laten aflopen om de seconde.
            klokje.Tick += new EventHandler(Wekker_Tick);
            klokje.Interval = new TimeSpan(0, 0, 1);

            LblFoutmelding.Visibility = Visibility.Hidden;
            TxtMaxWaarde.Text = "20";
        }
        private void Wekker_Tick(object sender, EventArgs e)
        {

            if (LblFoutmelding.IsVisible == true)
            {
                LblFoutmelding.Visibility = Visibility.Hidden;
            }
            else
            {
                LblFoutmelding.Visibility = Visibility.Visible;
            }
        }
        private void BtnOptellen_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder resultaat = new StringBuilder();
            if (int.TryParse(TxtMaxWaarde.Text, out int max) == true && max <= 20)
            {
                // Bij goede invoer --> Timer uitschakelen en label verbergen.
                klokje.IsEnabled = false;
                LblFoutmelding.Visibility = Visibility.Hidden;
                // Rijhoofding
                resultaat.Append(" ");
                for (int i = 1; i <= max; i++)
                {
                    resultaat.Append($"{i,4}");
                }
                //Kolommen
                resultaat.AppendLine().AppendLine();
                for (int i = 1; i <= max; i++)
                {
                    resultaat.Append($"{i,4}");
                    for (int j = 1; j <= max; j++)
                    {
                        resultaat.Append($"{i + j,4}");
                    }
                    resultaat.AppendLine();
                }
                TxtResultaat.Text = resultaat.ToString();
            }
            else
            {
                TxtMaxWaarde.Clear();
                TxtMaxWaarde.Focus();
                TxtResultaat.Clear();
                klokje.IsEnabled = true;
            }
        }
        private void BtnVermenigvuldigen_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder resultaat = new StringBuilder();
            if (int.TryParse(TxtMaxWaarde.Text, out int max) == true && max <= 20)
            {
                // Bij goede invoer --> timer uitschakelen en label verbergen
                klokje.IsEnabled = false;
                LblFoutmelding.Visibility = Visibility.Hidden;
                // Rijhoofding
                resultaat.Append(" ");
                for (int i = 1; i <= max; i++)
                {
                    resultaat.Append($"{i,4}");
                }
                //Kolommen
                resultaat.AppendLine().AppendLine();
                for (int i = 1; i <= max; i++)
                {
                    resultaat.Append($"{i,4}");
                    for (int j = 1; j <= max; j++)
                    {
                        resultaat.Append($"{i * j,4}");
                    }
                    resultaat.AppendLine();
                }
                TxtResultaat.Text = resultaat.ToString();
            }
            else
            {
                TxtMaxWaarde.Text = "";
                TxtMaxWaarde.Focus();
                TxtResultaat.Clear();
                klokje.IsEnabled = true;
            }
        }
        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            TxtMaxWaarde.Clear();
            TxtMaxWaarde.Focus();
        }
        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void TxtMaxWaarde_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Timer laten starten
            klokje.Stop();
        }
    }
}
