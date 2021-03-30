using Microsoft.VisualBasic;
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

namespace Oefening_27_Raadspelletje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int teller = 0;
        private int randomisedNumber = 0;
        public MainWindow()
        {
            InitializeComponent();

            Image imga = new Image();
            imga.Source = new BitmapImage(new Uri(@"images\1.jpg", UriKind.RelativeOrAbsolute));
            picture.Content = imga;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //randomised een getal
            Random rand = new Random();
            randomisedNumber = rand.Next(0, 100);
        }

        private void Start(object sender, RoutedEventArgs e)
        {
            teller++; //telt de beurten 


            //afbeeldingen
            Image imga = new Image();
            imga.Source = new BitmapImage(new Uri(@"images\1.jpg", UriKind.RelativeOrAbsolute));

            Image imgb = new Image();
            imgb.Source = new BitmapImage(new Uri(@"images\thumbsdown.png", UriKind.RelativeOrAbsolute));

            Image imgc = new Image();
            imgc.Source = new BitmapImage(new Uri(@"images\thumbsup.png", UriKind.RelativeOrAbsolute));


            string inputNumber = Interaction.InputBox("Geef een getal tussen 1 en 100",
                                                              "Raadspel",
                                                               "",
                                                               500);

            if (inputNumber == string.Empty)
            {
                MessageBox.Show("Geef een getal in","Foutmelding",MessageBoxButton.OK, MessageBoxImage.Error);;

                inputNumber = Interaction.InputBox("Geef een getal tussen 1 en 100",
                                                              "Raadspel",
                                                               "",
                                                               500);
            }
            else
            {
                if (int.Parse(inputNumber) < randomisedNumber)
                {
                    picture.Content = imgc;
                    MessageBox.Show("Raad hoger", "Raadspel");
                }
                else if (int.Parse(inputNumber) > randomisedNumber)
                {
                    picture.Content = imgb;
                    MessageBox.Show("Raad lager", "Raadspel");
                }
                else if (int.Parse(inputNumber) == randomisedNumber)
                { 
                    picture.Content = imga;
                    MessageBox.Show($"U heeft het getal geraden in {teller} beurten", "Proficiat!");  
                }
            }
        }

        private void Sluiten(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
