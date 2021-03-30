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

namespace TussentijdseTest2
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

        private void BerekenButton_Click(object sender, RoutedEventArgs e)
        {
            double aantalJaren, bedrag;
            bool isJaren = double.TryParse(aantalJarenText.Text, out aantalJaren);
            bool isBedrag = double.TryParse(bedragText.Text, out bedrag);

            // rente bepalen
            double rente = 2;

            if (bonusCheckBox.IsChecked == true)
            {
                rente = rente + 2;
                bedrag = bedrag - 1000;
            }
            if (secretCheckBox.IsChecked == true)
            {
                rente = rente + 2;
                bedrag = bedrag + 100;
            }


            if (isBedrag && bedrag > 0 && isJaren && aantalJaren > 0)
            {
                berekenButton.Background = Brushes.LightGray;
                string result;

                result = $"startbedrag = {bedrag}, jaarlijkse rente = {rente}%, aantal jaar = {aantalJaren}";

                for (int i = 1; i <= aantalJaren; i++)
                {
                    bedrag = bedrag + bedrag * (rente / 100);
                    if (aantalJaren - i < 10)
                    {
                        result = result + $"\njaar {i}: {bedrag}";
                    }
                }
                resultaatText.Text = result;
            }
            else
            {
                berekenButton.Background = Brushes.Red;
            }
        }

        private void AanmeldButton_Click(object sender, RoutedEventArgs e)
        {
            if (naamTextBox.Text == "admin")
            {
                achtergrondPanel.Background = Brushes.LightGray;
                secretCheckBox.Visibility = Visibility.Visible;
            }
            statusText.Background = Brushes.LightGreen;
            statusText.Text = "Je bent nu ingelogd als " + naamTextBox.Text;
            afmeldButton.Visibility = Visibility.Visible;
            naamTextBox.IsEnabled = false;
            berekenButton.IsEnabled = true;
        }
        private void AfmeldButton_Click(object sender, RoutedEventArgs e)
        {
            naamTextBox.IsEnabled = true;
            statusText.Text = "Je bent niet ingelogd.";
            statusText.Background = Brushes.LightSalmon;
            naamTextBox.Text = "";
            afmeldButton.Visibility = Visibility.Visible;
            achtergrondPanel.Background = Brushes.White;
            secretCheckBox.Visibility = Visibility.Hidden;
            afmeldButton.Visibility = Visibility.Hidden;
            secretCheckBox.IsChecked = false;
            berekenButton.IsEnabled = false;

        }
    }
}
