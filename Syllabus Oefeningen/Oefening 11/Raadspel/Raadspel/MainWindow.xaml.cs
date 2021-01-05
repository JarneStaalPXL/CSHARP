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
using System.Windows.Threading;

namespace Raadspel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss")}";
            },
            this.Dispatcher);

            
        }

        private int beurten = 0;
        private double randomGetal;
        private void Evalueer_Click(object sender, RoutedEventArgs e)
        {
            beurten++;
            double.TryParse(getalBox.Text, out double gekozenGetal);

            if (gekozenGetal > randomGetal)
            {
                guideBox.Text = "Raad lager!";
            }
            else if (gekozenGetal < randomGetal)
            {
                guideBox.Text = "Raad hoger!";
            }
            else if (gekozenGetal == randomGetal)
            {
                guideBox.Text = "Proficiat! U heeft het getal geraden!";
                guessBox.Text = $"Aantal keren geraden: {beurten}";
            }
        }

        private void Nieuw_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            randomGetal = rand.Next(0, 100);
        }


        private void Einde_Click(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
