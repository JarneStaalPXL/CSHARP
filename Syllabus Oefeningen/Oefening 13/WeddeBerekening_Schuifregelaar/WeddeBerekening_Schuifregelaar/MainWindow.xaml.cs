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
            slider.Minimum = 0;
            slider.Maximum = 100000;

             double salaris = slider.Value;

            if (salaris >= 50000)
            {
                double eersteWaarde = (salaris * 90) / 100;
                double tweedeWaarde = salaris - eersteWaarde;

                belasting.Content = $"€ {tweedeWaarde.ToString("0 000.00")}";
            }
            else if (salaris < 50000 && salaris >= 10000)
            {
                double eersteWaarde = (salaris * 20) / 100;
                double tweedeWaarde = salaris - eersteWaarde;

                belasting.Content = $"€ {tweedeWaarde.ToString("0 000.00")}";
            }
            else if (salaris <10000 )
            {
                double belastingWaarde = 0;
                belasting.Content = $"€ {belastingWaarde.ToString("0 000.00")}";
            }
        }
    }
}
