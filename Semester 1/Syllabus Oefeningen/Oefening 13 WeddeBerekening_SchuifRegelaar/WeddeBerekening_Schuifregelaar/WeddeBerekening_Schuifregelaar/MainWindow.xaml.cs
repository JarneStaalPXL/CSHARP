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

namespace WeddeBerekening_Schuifregelaar
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

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double belastingen;
            // Waarde inlezen van trackbar.
            double salaris = Schuifregelaar.Value;
            // Belastingen berekenen.
            if (salaris < 10000)
            {
                belastingen = 0;
            }
            else if (salaris < 50000)
            {
                belastingen = salaris * 0.2;
            }
            else
            {
                belastingen = salaris * 0.3;
            }
            // Belasting toekennen aan label.
            TxtBelastingen.Text = $"{belastingen:c}";
        }
    }
}
