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
using System.Windows.Shapes;

namespace Oefening_5_Woordenboek
{
    /// <summary>
    /// Interaction logic for WindowsZoeken.xaml
    /// </summary>
    public partial class WindowsZoeken : Window
    {
        
        public WindowsZoeken()
        {
            InitializeComponent();
        }

        private readonly Random rand = new Random();
        private int index = 0;
        private void BtnZoeken_Click_(object sender, RoutedEventArgs e)
        {
            index = rand.Next(0, Lexicon.ICTEngels.Count);
            TxtEngels.Text = Lexicon.ICTEngels[index];
        }

        private void BtnControle_Click(object sender, RoutedEventArgs e)
        {
            if (!string.Equals(TxtNederlands.Text, Lexicon.ICTNed[index]))
            {
                MessageBox.Show($"De vertaling is verkeerd.\n Het juiste aantwoord was {Lexicon.ICTNed[index].ToUpper()}", 
                "Fout", MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtNederlands.Focus();
                TxtNederlands.SelectAll();
            }
            else
            {
                MessageBox.Show("De vertaling is goed","Prima vertaling", MessageBoxButton.OK);
            } 
        }

        private void MnuVorigvenster_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            TxtEngels.Clear();
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
