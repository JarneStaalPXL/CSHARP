using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ValidatieLib
{
    public static class Validatie
    {
        public static string titel = "Foutmelding";
        public static string Titel {
            get { return titel; }
            set { titel = value; } }
        
        public static bool IsAanwezig(TextBox txt)
        {
            if (txt.Text.Length == 0 )
            {
                MessageBox.Show(txt.Tag + " is een vereist gegeven", Titel);
                return true;
            }
            else
            {
                Titel = "is vereist gegeven";
                return false;
            }

        }
        public static bool IsInteger(TextBox txt)
        {
            if (int.TryParse(txt.Text, out int value2))
            {
                MessageBox.Show(txt.Tag + " moet een geheel getal zijn", Titel);
                return false;
            }
            else
            {
                
                return true;
            }
        }

        public static bool IsDecimal(TextBox txt)
        {
            if (Decimal.TryParse(txt.Text, out decimal value))
            {
                MessageBox.Show(txt.Tag + " moet een decimaal getal zijn.?", Titel);
                return false;
            }
            else
            {
              
                return true;
            }
        }
    }
}
