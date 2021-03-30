using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BestandPuntenKlasse
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

    
        private OpenFileDialog ofd = new OpenFileDialog()
        {
            Filter = "Csv bestanden (*.csv) |*.csv|Tekstbestanden (*.txt) |*.txt|" +
            "Alle bestanden (*.*)|*.*",
            InitialDirectory = System.IO.Path.GetFullPath(@"..\..\Bestanden"),
            Title = "Bestand openen",
            FileName="Punten.csv",
            AddExtension = true,
            DefaultExt = "csv",
        };

        // Modulevariabele of klassevariabele.
        private string fileName;
        // LIST AANMAKEN VOOR KLASSE
        private List<PuntenAdmin> pntAdmin = new List<PuntenAdmin>();

        private void BtnInlezen_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
           
            // Read file.
            if (ofd.ShowDialog() == true)
            {
                fileName = ofd.FileName;

                if (File.Exists(fileName))
                {
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        //VERWERKING
                        PuntenAdmin ad = new PuntenAdmin();
                        while (!sr.EndOfStream)
                        {
                            string[] lijnen = sr.ReadLine().Split(';');

                            //CSV FILE
                            string[] naamSplitsing = lijnen[0].Trim().Split(' '); //Familyname and 
                            ad.Familyname = naamSplitsing[0].Trim();
                            ad.FirstName = naamSplitsing[1].Trim();

                            ad.Email = lijnen[1].Trim();
                            ad.Gender = lijnen[2].Trim();
                            string punten1 = lijnen[3].Substring(0, 3);
                            string punten2 = lijnen[3].Substring(3, 3);

                            ad.Score = int.Parse(punten1);
                            ad.TotalScore = int.Parse(punten2);


                            sb.Append($"{(ad.FirstName + ' ' + ad.Familyname),-21}{ad.Email,-21}" +
                                $"{ad.Gender,-5}{ad.Score}/{ad.TotalScore}").AppendLine();

                            pntAdmin.Add(ad);
                        }
                    }
                    BtnVerwerken.IsEnabled = true;
                    
                    TxtResultaat.Text = sb.ToString();

                    // Je wilt vb. de familienaam van iemand uit de list halen
                    // TxtResultaat.Text = pntAdmin[5].Familyname;
                }
                else
                {
                    MessageBox.Show("File does not exist", "Error message", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        public void BtnNalezen_Click(object sender, RoutedEventArgs e)
        {
            // Openen van bestaand dialoogvenster dlgOpenBestand.
            ofd.ShowDialog();
            fileName = ofd.FileName;
        
            //Tekstvak leegmaken
            TxtResultaat.Clear();

            // Testen of bestand bestaat. Maar met OpenFileDialog is de kans klein want je kan in principe geen onbestaand bestand openen.
            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    TxtResultaat.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("Bestand " + System.IO.Path.GetFileName(fileName) + " bestaat niet", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void BtnVerwerken_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Alle bestanden (*.*)|*.*| CSV bestanden (*.csv)|*.csv|Tekstbestanden (*.txt)|*.txt",
                FilterIndex = 2,
                InitialDirectory = System.IO.Path.GetFullPath(@"..\..\Bestanden"),
                Title = "Geef een bestandsnaam op",
                FileName = "PuntenVerwerkt.csv",
                //--- Bevestiging wordt gevraagd bij overschrijven van een bestand
                OverwritePrompt = true
            };

            //Bewaren voor afdruk
            // bestandsnaam = sfd.FileName; // pad + bestandsnaam  van klasse SystemIO.Path
            //bestandsnaam = Path.GetDirectoryName(dlgBewaarBestand.FileName)  // enkel pad
            //bestandsnaam = Path.GetFileName(dlgBewaarBestand.FileName);      // enkel bestandsnaam
            
            if (sfd.ShowDialog() == true)
            {
                //Bestand opslaan
                using (StreamWriter sw = File.CreateText(sfd.FileName))
                {
                    // GEGEVENS WEGSCHRIJVEN
                    foreach (var item in pntAdmin)
                    {
                        sw.WriteLine($"{item.Familyname} {item.FirstName};{item.Percent():p}" +
                            $";{item.Grade()}");
                    }
                    
                    
                }
                MessageBox.Show("De resultaten zijn verwerkt. " +
                " Je kan de resultaten nalezen in het bestand " + sfd.FileName,
                "Resultaten", MessageBoxButton.OK, MessageBoxImage.Information);

                BtnNalezen.IsEnabled = true;
            }
            else
            {
                MessageBox.Show("De resultaten zijn niet verwerkt. ",
                "Resultaten", MessageBoxButton.OK, MessageBoxImage.Information);
            }
          
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Installeren van timer dmv de klasse aan te spreken.
            DispatcherTimer wekker = new DispatcherTimer();

            // Timer laten aflopen om de seconde.
            wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            wekker.Interval = new TimeSpan(0, 0, 1); //uren, minuten, seconden

            // Timer laten starten
            wekker.Start();

            // TIJD instellen.
            TextBlockDateTime.Text = $"{DateTime.Now.ToLongDateString()}   {DateTime.Now.ToLongTimeString()}";
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            TextBlockDateTime.Text = $"{DateTime.Now.ToLongDateString()}   {DateTime.Now.ToLongTimeString()}";
        }

       
    }
}

