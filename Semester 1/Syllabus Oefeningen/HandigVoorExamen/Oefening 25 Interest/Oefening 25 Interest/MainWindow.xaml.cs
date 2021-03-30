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

namespace Oefening_25_Interest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private StringBuilder resultaat = new StringBuilder();
        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int tel;
            float waarde;
            // Inlezen van variabelen.
            int beginkapitaal = int.Parse(TxtBeginkapitaal.Text);
            int eindkapitaal = int.Parse(TxtEindkapitaal.Text);
            float intrestvoet = float.Parse(TxtIntrest.Text);
            float rente = 1 + intrestvoet / 100;
            // Stringbuilder terug leegmaken bij volgende berekening
            resultaat.Clear();
            TxtResultaat.Clear();
            if (eindkapitaal < beginkapitaal)
            {
                MessageBox.Show("Beginkapitaal is groter dan het eindkapitaal!", "Foute invoer"
                , MessageBoxButton.OK, MessageBoxImage.Warning);
                TxtBeginkapitaal.SelectAll();
                TxtBeginkapitaal.Focus();
            }
            else
            {
                tel = 1;
                waarde = beginkapitaal;

                while (waarde < eindkapitaal && tel <= 100)
                {
                    waarde *= rente;
                    resultaat.Append($"Waarde na {tel,2} jaren: {waarde:c}").AppendLine();
                    tel++;
                }
                TxtResultaat.Text = resultaat.ToString();
            }
        }
        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtBeginkapitaal.Clear();
            TxtEindkapitaal.Clear();
            TxtIntrest.Clear();
            TxtResultaat.Clear();
            TxtBeginkapitaal.Focus();
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Resultaatwaarde
            MessageBoxResult antw = MessageBox.Show("Wil je echt afsluiten?", "Project afsluiten.",
            MessageBoxButton.YesNo, MessageBoxImage.Question, MessageBoxResult.No);
            if (antw == MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else
            { // Cancel het Closing-event en form wordt niet gesloten.
                e.Cancel = true;
            }
        }
        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void TxtBeginkapitaal_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9)
           || (e.Key >= Key.D0 && e.Key <= Key.D9) && e.KeyboardDevice.Modifiers == ModifierKeys.Shift
           || e.Key == Key.OemComma
           || e.Key == Key.Back)
            {
                e.Handled = false; // invoer wordt geaccepteerd
            }
            else
            {
                e.Handled = true; // invoer wordt geweigerd
            }
        }

        private void BtnBerekenen_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
