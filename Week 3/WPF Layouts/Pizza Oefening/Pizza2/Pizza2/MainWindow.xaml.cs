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

namespace Pizza2
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

        
        
        
        private void bestelKnop_Click(object sender, RoutedEventArgs e)
        {
            double totaal1;
            double totaal2;
            double totaal3;
            double totaal4;
            double totaal5;
            double totaal6;
            double totaal7;
            
            string persoonsGegevens = $"naam: {invoerNaam.Text}\nTelefoonnummer: {invoerTelefoonnummer.Text} \nE-mail: {invoerEmail.Text} \n" +
                $"Adres: {invoerAdres.Text}\nWoonplaats: {invoerWoonplaats.Text}\nPostcode: {invoerPostcode.Text}\n" +
                $"\nU heeft de volgende pizza's besteld\n-------------------------------------------------------------\n";




            totaal1 = Convert.ToDouble(invoerAantal1.Text) * Convert.ToDouble(prijs1.Text);
            totaal2 = Convert.ToDouble(invoerAantal2.Text) * Convert.ToDouble(prijs2.Text);
            totaal3 = Convert.ToDouble(invoerAantal3.Text) * Convert.ToDouble(prijs3.Text);
            totaal4 = Convert.ToDouble(invoerAantal4.Text) * Convert.ToDouble(prijs4.Text);
            totaal5 = Convert.ToDouble(invoerAantal5.Text) * Convert.ToDouble(prijs5.Text);
            totaal6 = Convert.ToDouble(invoerAantal6.Text) * Convert.ToDouble(prijs6.Text);
            totaal7 = Convert.ToDouble(invoerAantal7.Text) * Convert.ToDouble(prijs7.Text);

            int totaalPizzas = Convert.ToInt32(aantal1 + aantal2 + aantal3 + aantal4 + aantal5 + aantal6 + aantal7);
            double extraTopping = 0;
            if (extraMozzarella.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraSalami.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraAnsjovis.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraArtisjok.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraCheese.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraPaprika.IsChecked == true)
            {
                extraTopping += 0.50;
            }
            if (extraOlives.IsChecked == true)
            {
                extraTopping += 0.50;
            }

            double totaalBedrag = totaal1 + totaal2 + totaal3 + totaal4 + totaal5 + totaal6 + totaal7 + (totaalPizzas * extraTopping);

           


            uitvoer.Text = ($"{persoonsGegevens} Quattro Stagioni €{totaal1}\n Capricciosa €{totaal2}\n Salami Al Fuoco €{totaal3}\n Prosciutto Cotto €{totaal4}\n Quattro Fromaggi €{totaal5}\n Hawaï €{totaal6}\n Margherita " +
                $"€{totaal7}\n extra toppings per pizza: €{extraTopping}\n Aantal Pizza's: {totaalPizzas}\n U totaalbedrag is: €{totaalBedrag} ");

           
            





        }
        int aantal1;
        private void plusKnop1_Click(object sender, RoutedEventArgs e)
        {
            aantal1++;
            invoerAantal1.Text = aantal1.ToString();
            
        }

        private void minKnop1_Click(object sender, RoutedEventArgs e)
        {
            if (aantal1 > 0)
            {
                aantal1--;
                invoerAantal1.Text = aantal1.ToString();

            }                   
        }

        int aantal2;
        private void plusKnop2_Click(object sender, RoutedEventArgs e)
        {
            aantal2++;
            invoerAantal2.Text = aantal2.ToString();
        }

        private void minKnop2_Click(object sender, RoutedEventArgs e)
        {
            if (aantal2 > 0)
            {
                aantal2--;
                invoerAantal2.Text = aantal2.ToString();
            }
        }

        int aantal3;
        private void plusKnop3_Click(object sender, RoutedEventArgs e)
        {
            aantal3++;
            invoerAantal3.Text = aantal3.ToString();
        }

        private void minKnop3_Click(object sender, RoutedEventArgs e)
        {
            if (aantal3 > 0)
            {
                aantal3--;
                invoerAantal3.Text = aantal3.ToString();
            }
        }

        int aantal4;
        private void plusKnop4_Click(object sender, RoutedEventArgs e)
        {
            aantal4++;
            invoerAantal4.Text = aantal4.ToString();
        }

        private void minKnop4_Click(object sender, RoutedEventArgs e)
        {
            if (aantal4 > 0)
            {
                aantal4--;
                invoerAantal4.Text = aantal4.ToString();
            }
        }

        int aantal5;
        private void plusKnop5_Click(object sender, RoutedEventArgs e)
        {
            aantal5++;
            invoerAantal5.Text = aantal5.ToString();
        }

        private void minKnop5_Click(object sender, RoutedEventArgs e)
        {
            if (aantal5 > 0)
            {
                aantal5--;
                invoerAantal5.Text = aantal5.ToString();
            }
        }

        int aantal6;
        private void plusKnop6_Click(object sender, RoutedEventArgs e)
        {
            aantal6++;
            invoerAantal6.Text = aantal6.ToString();
        }

        private void minKnop6_Click(object sender, RoutedEventArgs e)
        {
            if (aantal6 > 0)
            {
                aantal6--;
                invoerAantal6.Text = aantal6.ToString();
            }
        }

        int aantal7;
        private void plusKnop7_Click(object sender, RoutedEventArgs e)
        {
            aantal7++;
            invoerAantal7.Text = aantal7.ToString();
        }

        private void minKnop7_Click(object sender, RoutedEventArgs e)
        {
            if (aantal7 > 0)
            {
                aantal7--;
                invoerAantal7.Text = aantal7.ToString();
            }
        }

    
      
        private void extraMozzarella_Click_1(object sender, RoutedEventArgs e)
        {
            if (extraMozzarella.IsChecked == true)
            {
                mozarella.Visibility = Visibility.Visible;
            }
            else
            {
                mozarella.Visibility = Visibility.Hidden;

            }

        }
        private void extraSalami_Click(object sender, RoutedEventArgs e)
        {
            if (extraSalami.IsChecked == true)
            {
                salami.Visibility = Visibility.Visible;
            }
            else
            {
                salami.Visibility = Visibility.Hidden;

            }
        }

        private void extraAnsjovis_Click(object sender, RoutedEventArgs e)
        {
            if (extraAnsjovis.IsChecked == true)
            {
                ansjovis.Visibility = Visibility.Visible;
            }
            else
            {
                ansjovis.Visibility = Visibility.Hidden;

            }

        }

        private void extraArtisjok_Click(object sender, RoutedEventArgs e)
        {
            if (extraArtisjok.IsChecked == true)
            {
                artisjok.Visibility = Visibility.Visible;
            }
            else
            {
                artisjok.Visibility = Visibility.Hidden;

            }
        }

        private void extraCheese_Click(object sender, RoutedEventArgs e)
        {
            if (extraCheese.IsChecked == true)
            {
                cheese.Visibility = Visibility.Visible;
            }
            else
            {
                cheese.Visibility = Visibility.Hidden;

            }
        }

        private void extraPaprika_Click(object sender, RoutedEventArgs e)
        {
            if (extraPaprika.IsChecked == true)
            {
                paprika.Visibility = Visibility.Visible;
            }
            else
            {
                paprika.Visibility = Visibility.Hidden;
            }
        }

        private void extraOlives_Click(object sender, RoutedEventArgs e)
        {
            if (extraOlives.IsChecked == true)
            {
                olives.Visibility = Visibility.Visible;
            }
            else
            {
                olives.Visibility = Visibility.Hidden;
            }
        }


    }


}
