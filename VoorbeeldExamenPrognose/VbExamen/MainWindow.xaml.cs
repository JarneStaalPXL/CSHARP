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

namespace VbExamen
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

        private List<string> namen = new List<string>() { "Sander", "Quirino", "Thomas",
            "Cédric", "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander",
            "Yannick", "Robin", "Dave", "Lynn", "Arno", "Niels", "Maxiem", "Matthijs", "Kobe",
            "Michaël", "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven",
            "Rani", "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
            "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
            "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
            "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
            "Kenneth" };
        private string[,] lidgeldPerCat = { { "Preminiem", "150" }, { "Miniem", "150" }, {
        "Junior", "170" }, { "Kadet", "170" },{ "Senior", "200" } };
        private TextBox[] prognoseVakken = new TextBox[6];

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Combobox namen invullen
            foreach (string naam in namen)
            {
                ComboBoxItem nm = new ComboBoxItem();
                nm.Content = naam;
                ComboboxNamen.Items.Add(nm);
            }
            //alle items uit stackpanel naar categorie
            int i = 0;
            foreach (var item in StackPanelPrognose.Children)
            {
                if (item is TextBox)
                {
                    prognoseVakken[i] = (TextBox)item;
                    i++;
                }
            }

            CheckCompetitie.IsChecked = false;
            CheckNieuwLid.IsChecked = false;

            TxtRangGezin.Text = "1";

            //installeren van timer dmv de klasse aan te spreken.
            DispatcherTimer wekker = new DispatcherTimer();

            //timer laten aflopen om de seconde.
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1); //uren, minuten, seconden

            // timer laten starten.
            wekker.Start();

            //tijd instellen.
            LblTijd.Content = $"{DateTime.Now.ToLongDateString()}   {DateTime.Now.ToLongTimeString()}";
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            LblTijd.Content = $"{DateTime.Now.ToLongDateString()}   {DateTime.Now.ToLongTimeString()}";
        }

        private void berekenen()
        {
            float teBetalen, lidgeld = 0, verbetering = 0.05f;
            int breedte = 380;

            if (ComboboxNamen.SelectedIndex == -1)
            {
                MessageBox.Show("Geen deelnemer geselecteerd!", "Invoer gegevens", MessageBoxButton.OK, MessageBoxImage.Error);
                ComboboxNamen.IsDropDownOpen = true;
            }
            else
            {
                //basisbedrag.
                int i = 0;
                foreach (RadioButton item in StackpanelCategorie.Children)
                {
                    if (item.IsChecked == true)
                    {
                        //lidgeld = dict [item.Content.Tostring()];
                        lidgeld = int.Parse(lidgeldPerCat[i, 1]);

                    }
                    i++;
                }

                //competitielid betaald 50 euro meer.
                teBetalen = (CheckCompetitie.IsChecked == true) ? lidgeld + 50 : lidgeld;

                //rangnummer van gezin.
                teBetalen *= (1 - (float.Parse(TxtRangGezin.Text) - 1) * 0.05f);

                //Resultaat afdrukken.
                TxtResultaat.Text = $"Inschrijvingsbedrag voor {ComboboxNamen.Text}\r\n\r\n"
                    + $"Basisbedrag voor {ComboboxNamen.Text} : {lidgeld}\r\n Te betalen: {teBetalen}";

                if (CheckNieuwLid.IsChecked == true)
                {
                    //prognosestaafjes herschikken voor nieuw lid.
                    if (float.TryParse(TxtTijd.Text, out float tijd))
                    {
                        //prognose zichtbaar maken.
                        StackPanelPrognose.Visibility = Visibility.Visible;

                        foreach (TextBox tb in prognoseVakken)
                        {
                            tb.Text = $"{tijd:f2}";
                            tb.Width = breedte;
                            //vb: 1000*095(= 1-0.05)...950*0.95...
                            tijd *= (1 - verbetering);
                            breedte = (int)(breedte * (1 - verbetering));
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geef een correcte tijd in", "Foute tijd",
                            MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        TxtTijd.Focus();
                    }

                }
                else
                {
                    //prognose onzichtbaar maken.
                    StackPanelPrognose.Visibility = Visibility.Hidden;
                    LblPrognoseInfo.Visibility = Visibility.Hidden;
                }
            }
        }
        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            berekenen();
        }


        private void Wissen()
        {
            //tekstvakken van formulier leeg maken.
            foreach (TextBox tb in prognoseVakken)
            {
                // Textbox wordt leeggemaakt.
                tb.Clear();
            }

            //prognose onzichtbaar maken.
            StackPanelPrognose.Visibility = Visibility.Hidden;
            LblPrognoseInfo.Visibility = Visibility.Hidden;

            ComboboxNamen.SelectedIndex = -1;

            TxtTijd.Clear();
            TxtResultaat.Clear();
            TxtRangGezin.Text = "1";
            //radJunior.IsChecked = true; // Roept BtnBerekenen op !!
            CheckCompetitie.IsChecked = false;
            CheckNieuwLid.IsChecked = false;
            ComboboxNamen.Focus();
        }
        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            Wissen();
        }

        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
