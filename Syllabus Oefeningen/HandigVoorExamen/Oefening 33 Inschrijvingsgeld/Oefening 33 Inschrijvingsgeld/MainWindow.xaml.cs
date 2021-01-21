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

namespace Oefening_33_Inschrijvingsgeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string[,] array = new string[5, 2] {
                                    {"Programmeren","920,80" },
                                    {"Netwerkbeheer","920,80" },
                                    {"Internet of Things","520,80" },
                                    {"Digitale Vormgever","750,80" },
                                    {"Drone opleiding","520,80" },
        };
        private float basisbedrag = 0f;
        private float korting = 0f;
        private float toeslag = 0f;
        private float eindResultaat = 0f;

        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                opleidingBox.Items.Add(array[i,0]);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            korting = 0.05f;
        }

        private void Unchecked(object sender, RoutedEventArgs e)
        {
            korting = 0.00f;
        }

        private void opleidingBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (opleidingBox.SelectedIndex == i)
                {
                  basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
                }
            }
           
            //if (opleidingBox.SelectedIndex == 0)
            //{
            //    basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
            //}
            //else if (opleidingBox.SelectedIndex == 1)
            //{
            //    basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
            //}
            //else if (opleidingBox.SelectedIndex == 2)
            //{
            //    basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
            //}
            //else if (opleidingBox.SelectedIndex == 3)
            //{
            //    basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
            //}
            //else if (opleidingBox.SelectedIndex == 4)
            //{
            //    basisbedrag = float.Parse(array[opleidingBox.SelectedIndex, 1]);
            //}
        }

        private void berekenen(object sender, RoutedEventArgs e)
        {
            if (werkzoekendBox.IsChecked == true)
            {
                korting = 0.50f;
            }
            else if (optieA.IsChecked == true)
            {
                korting = 0.30f;
            }
            else if (optieB.IsChecked == true)
            {
                korting = 0.20f;
            }
            else if (optieC.IsChecked == true)
            {
                korting = 0f;
            }
            else if (optieD.IsChecked == true)
            {
                toeslag = 0.10f;
            }


            eindResultaat = basisbedrag * korting;
            outputBox.Text = $"INSCHRIJVINGSBEDRAG VOOR: {naamBox.Text}\n\n"+
                $"Basisbedrag: € {basisbedrag}\n"+
                $"Te betalen: € {basisbedrag - eindResultaat +(basisbedrag * toeslag)}";
        }

        private void Wissen(object sender, RoutedEventArgs e)
        {

            outputBox.Text = string.Empty;
    }

        private void Afsluiten(object sender, RoutedEventArgs e)
        {

        }
    }
}
