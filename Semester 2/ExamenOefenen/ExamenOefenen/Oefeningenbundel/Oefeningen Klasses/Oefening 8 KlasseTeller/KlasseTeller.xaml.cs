using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefening_8_KlasseTeller
{
    /// <summary>
    /// Interaction logic for KlasseTeller.xaml
    /// </summary>
    public partial class KlasseTeller : Window
    {
        public KlasseTeller()
        {
            InitializeComponent();
        }

        private void Einde_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LezenWaardeTeller(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"{Teller.Counter}");
        }

        private void VerhoogTellerClick(object sender, RoutedEventArgs e)
        {
            Teller teller = new Teller();
            teller.VerhoogTeller();
        }

        private void VerminderTellerClick(object sender, RoutedEventArgs e)
        {
            Teller teller = new Teller();
            teller.VerminderTeller();
        }

        private void ResettenTellerClick(object sender, RoutedEventArgs e)
        {
            Teller teller = new Teller();
            teller.ResetTeller();
        }

        private void VerhoogTellerMetClick(object sender, RoutedEventArgs e)
        {
            Teller teller = new Teller();

            int number = 0;
            if (inputTeller.Text != string.Empty )
            {
                number = int.Parse(inputTeller.Text);
                teller.Waarde(number);
            }
            else
            {
                MessageBox.Show("Please fill in a number");
            }
            
            
        }
    }
}
