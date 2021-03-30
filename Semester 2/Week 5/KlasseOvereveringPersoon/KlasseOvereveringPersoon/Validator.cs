using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KlasseOvereveringPersoon
{
    public class Validator
    {
        public static string Title { get; set; } = "Foutmelding";
        public static bool IsPresent(TextBox txtVak)
        {
            if (txtVak.Text == string.Empty)
            {
                MessageBox.Show(txtVak.Tag + " moet ingevuld worden!", Title);
                return false;
            }
            return true;
        }

        public static bool IsValidEmail(TextBox txtVak)
        {
            if (txtVak.Text.IndexOf("@") == -1 || txtVak.Text.IndexOf(".") == -1)  //-1 Is niet aanwezig
            {
                MessageBox.Show(txtVak.Tag + " moet een geldig e-mailadres zijn.", Title);
                txtVak.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
