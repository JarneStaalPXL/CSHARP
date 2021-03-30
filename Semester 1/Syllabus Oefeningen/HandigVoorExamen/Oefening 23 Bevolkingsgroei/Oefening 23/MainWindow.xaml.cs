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

namespace Oefening_23
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

        private void Berekenen(object sender, RoutedEventArgs e)
        {
            int.TryParse(currentPopulationBox.Text, out int currentPopulation);
            float.TryParse(growthPercentageBox.Text, out float growth);
            float years = (70 / growth);

            double currentPopulationAfterYears = currentPopulation * Math.Pow(Math.E, (growth/100) * years);

            

            if (growthPercentageBox.Text == "" || growthPercentageBox.Text == "0")
            {
                MessageBox.Show("Zonder groeipercentage nooit een verdubbeling van de bevolking");
                outputBox.Text = "";
            }
            else
            {
                outputBox.Text = $"Verdubbeling bevolking in {landBox.Text} na {Math.Ceiling(years)} jaren" +
            $"\n\nNieuw bevolkingsaantal op dat moment: {currentPopulationAfterYears}";
            }

            
        }
    }
}
