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

namespace Klasse_SportkampLeden
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

        private string bestand = @"LedenSportkampen.txt";
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Leden leden = new Leden();

            string[] code = { "ATL", "VOE", "ZWE", "KAY", "TEN", "PAA", "VOL" };
            float[,] overzichtWeek = new float[10, 2];
            float[,] overzichtSport = new float[code.Length, 2];

            StringBuilder sbDetail = new StringBuilder();
            StringBuilder sbOverzichtWeek = new StringBuilder();
            StringBuilder sbOverzichtSport = new StringBuilder();

            if (File.Exists(bestand))
            {
                using (StreamReader sr = new StreamReader(bestand))
                {
                    while (!sr.EndOfStream)
                    {
                        string lijn = sr.ReadLine();
                        leden.Naam = lijn.Substring(30, 29).Trim();
                        leden.Weeknr = int.Parse(lijn.Substring(60, 1));
                        leden.Kampcode = lijn.Substring(61, 3);
                        //leden.KampVolgnr = int.Parse(lijn.Substring(61, 4)); give error

                        sbDetail.Append(leden.InformatieVolledig()).AppendLine();

                        overzichtWeek[leden.Weeknr, 0]++;
                        overzichtWeek[leden.Weeknr, 1] += leden.TeBetalen;

                        for (int i = 0; i <= code.GetUpperBound(0); i++)
                        {
                            if (leden.Kampcode == code[i])
                            {
                                overzichtSport[i, 0]++;
                                overzichtSport[i, 1] += leden.TeBetalen;
                            }
                        }
                    }
                }

                //Afdruk txtDetail
                TxtDetails.Text = $"Details van alle leden.\n\n{sbDetail.ToString()}";

                //Afdruk txtOverzichtWeek
                sbOverzichtWeek.Append("Overzicht per week\n\n");
                for (int i = 0; i < overzichtWeek.GetUpperBound(0); i++)
                {
                    sbOverzichtWeek.Append($"Week {i} - {overzichtWeek[i, 0]}" +
                        $"inschrijvingen:         {overzichtWeek[i, 1]:c}").AppendLine();
                }

                TxtOverzichtWeek.Text = sbOverzichtWeek.ToString();


                //Afdruk txtOverzichtSport
                sbOverzichtSport.Append("Overzicht per Sporttak\n\n");

                for (int i = 0; i < overzichtSport.GetUpperBound(0); i++)
                {
                    leden.Kampcode = code[i].ToString();
                    sbOverzichtSport.Append($"{leden.SportNaam,-11} - {overzichtSport[i, 0]}" +
                        $"inschrijvingen=  {overzichtSport[i, 1]:c}").AppendLine();
                }

                TxtOverzichtSporttak.Text = sbOverzichtSport.ToString();
            }
            else
            {
                MessageBox.Show("Bestand LedenSportkamp is niet beschikbaar en er " +
                    "kunnen geen gegevens ingelezen worden","Foutmelding");

            }
        }
    }
}
