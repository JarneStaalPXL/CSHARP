using System.Windows;
using System.Windows.Controls;

namespace Validatie
{
    public static class Validatie
    {
        public static string Titel { get; set; }

        public static bool isAanwezig(TextBox txt, TextBox txt1)
        {
            if (txt.Text != string.Empty && txt1.Text != string.Empty)
            {
                Titel = "Tekstvakken zijn correct ingevuld";
                return true;
            }
            else
                return false;
        }

        public static bool isInteger(TextBox txt)
        {
            if (txt.Text == string.Empty)
            {
                MessageBox.Show("Geheel getal is een vereiste gegeven.", "Foutmelding");
                return false;
            }
            else if (int.TryParse(txt.Text, out int value))
            {
                return true;
            }
            else
                return false;
        }

        public static bool isDecimal(TextBox txt)
        {
            decimal value = decimal.Parse(txt.Text);
            if (txt.Text == string.Empty)
            {
                MessageBox.Show("Decimaal getal moet een decimaal getal zijn.", "Foutmelding");
                
                return false;
            }
            else if ((value % 1) > 0)
            {
                Titel = "Tekstvakken zijn correct ingevuld";
                return true;
            }
            else
                return false;
        }
        
    }
}
