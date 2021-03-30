using System;
using System.Collections.Generic;
using System.IO;
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

namespace Oefening_4_Zonnepanelen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string bestand = @"..\..\Bestanden\Zonnepanelen.txt";
        private List<string> maanden = new List<string>() 
        { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };
        private Random rand = new Random();
        private int vorigeKleur = 0;


        public MainWindow()
        {
            InitializeComponent();
        }


        private string Seizoen(int maand)
        {
            string afb = "winter.jpg";
            switch (maand)
            {
                case 3:
                case 4:
                case 5:
                    afb = "lente.jpg";
                    break;
                case 6:
                case 7:
                case 8:
                    afb = "zomer.jpg";
                    break;
                case 9:
                case 10:
                case 11:
                    afb = "herfst.jpg";
                    break;
            }
            return afb;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.TextBlockDateTime.Text = $"{DateTime.Now.ToString("dddd HH:mm:ss")}";
            },
            this.Dispatcher);

            string seizoensafb = Seizoen(DateTime.Today.Month); // huidige datum 

            string bestand = System.IO.Path.Combine(@"..\..\Bestanden", seizoensafb);
            if (File.Exists(bestand))
            {
                ImgSeizoen.Source = new BitmapImage(new Uri(bestand, UriKind.RelativeOrAbsolute));
            }
            else
            {
                MessageBox.Show("Kan afbeelding niet inladen!", "Ongeldig Bestand", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }


        
        private void MnuDetails_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(bestand))
            {
                TxtResultaat.Text = File.ReadAllText(bestand);
            }
            else
            {
                MessageBox.Show("Kan bestand niet vinden.", "Onverwachte fout.", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void MnuSamenvatting_Click(object sender, RoutedEventArgs e)
        {
            float[,] metingen = new float[13, 2];
            int aantalMetingen = 0;
            float totProductie = 0;
            

            try
            {
                using (StreamReader sr = File.OpenText(bestand))
                {
                    string[] velden = new string[2];

                    while (!sr.EndOfStream)
                    {
                        velden = sr.ReadLine().Split('-');

                        int maandIndex = int.Parse(velden[0].Substring(3, 2));
                        metingen[maandIndex, 0]++;
                        metingen[maandIndex, 1] += float.Parse(velden[1]);
                        aantalMetingen++;
                    }
                }

                StringBuilder sb = new StringBuilder();
                sb.Append("SAMENVATTING VAN DE METINGEN:\n\n");

                for (int i = 1; i < metingen.GetUpperBound(0); i++)
                {
                    totProductie += metingen[i, 1];
                    sb.Append($"{maanden[i - 1],14} - {metingen[i, 0],5} metingen   "+
                        $"-Gemiddelde Productie per dag: {metingen[i,1]/ metingen[i,0],6:n2}\n");
                }
                totProductie /= aantalMetingen;
                sb.Append($"\n{"Algemeen",-14} - {aantalMetingen,5} metingen   " +
                    $"- Gemiddelde Productie per dag: {totProductie,6:n2}");

                TxtResultaat.Text = sb.ToString();

            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Geef nieuwe naam!\n\n" + ex.Message, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Kan het bestand niet vinden", "Onverwachte fout.", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void MnuDatum_Click(object sender, RoutedEventArgs e)
        {
            if (MnuDatum.IsChecked == true)
            {
                TextBlockDateTime.Visibility = Visibility.Visible;
            }
            else
            {
                TextBlockDateTime.Visibility = Visibility.Hidden;
            }
        }

        private void MnuAchtergrond_Click(object sender, RoutedEventArgs e)
        {
            int kleur = rand.Next(1, 6);
            while (kleur == vorigeKleur)
            {
                kleur = rand.Next(1, 6);
            }

            vorigeKleur = kleur;

            switch (kleur)
            {
                case 1:
                    Background = Brushes.Gold;
                    break;
                case 2:
                    Background = Brushes.BlueViolet;
                    break;
                case 3:
                    Background = Brushes.LightGreen;
                    break;
                case 4:
                    Background = Brushes.Silver;
                    break;
                case 5:
                    Background = Brushes.MediumVioletRed;
                    break;
            }
        }
    }
}
