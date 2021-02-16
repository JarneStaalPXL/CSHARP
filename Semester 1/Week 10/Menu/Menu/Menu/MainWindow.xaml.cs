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

namespace Menu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> soorten = new List<string>() { "klaveren", "harten", "ruiten", "schuppen" };
        private List<string> deckVanKaarten = new List<string>();



        public MainWindow()
        {
            InitializeComponent();

            StringBuilder console = new StringBuilder();

            int[,] veld = new int[,]
            {
                { 2, 3 },
                { 0, 7 },
                { 5, 8 }
            };
            int aantalRijen = veld.GetLength(0);
            console.AppendLine(aantalRijen.ToString());
            console.AppendLine($"{veld[1, 1]}");
            console.AppendLine(veld[1, 1] + "");
            for (int i = 0; i < veld.GetLength(0); i++)
            {
                for (int j = 0; j < veld.GetLength(1); j++)
                {
                    console.AppendLine(veld[i, j].ToString());
                }
            }

            Console.Text = console.ToString();

            //    for (int i = 0; i < soorten.Count; i++)
            //    {
            //        for (int j = 1; j < 14; j++)
            //        {
            //            switch (j)
            //            {
            //                case 11:
            //                    deckVanKaarten.Add(soorten + " boer");
            //                    break;
            //                default:
            //                    deckVanKaarten.Add(soorten + " " + j);
            //                    break;
            //            }
            //        }
            //    }
            //}
        }
        private void MenuItemAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void View_Click(object sender, RoutedEventArgs e)
        {
        }
        private void ViewMenuItem_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Fill_Click(object sender, RoutedEventArgs e)
        {
            //Achtergrond.Stretch = Stretch.Fill;
        }
        private void UniformToFill_Click(object sender, RoutedEventArgs e)
        {
            //Achtergrond.Stretch = Stretch.UniformToFill;
        }
    }
}

