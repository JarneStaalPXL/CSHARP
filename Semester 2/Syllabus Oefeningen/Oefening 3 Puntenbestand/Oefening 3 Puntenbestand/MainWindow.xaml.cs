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
using System.IO;
using Microsoft.Win32;

namespace Oefening_3_Puntenbestand
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
        private Dictionary<string, string> dicGeg = new Dictionary<string, string>();
        private string bestandsnaam;

        private void INLEZEN(object sender, RoutedEventArgs e)
        {
            string path = @"..\..\Bestanden";

            StringBuilder sb = new StringBuilder();
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt)|*.txt",
                InitialDirectory = System.IO.Path.GetFullPath(path),
                Title = "Bestand openen",
                AddExtension = true,
                DefaultExt ="txt",
                FileName = "Punten.txt"
            };
            if (ofd.ShowDialog() == true)
            {
                bestandsnaam = ofd.FileName;

                using (StreamReader sr = File.OpenText(bestandsnaam))
                {
                    string lijn, veld1, veld2, veld3, veld4;

                    while (!sr.EndOfStream)
                    {
                        lijn = sr.ReadLine();
                        veld1 = lijn.Substring(0, 18).Trim();
                        veld2 = lijn.Substring(19, 20).Trim();
                        veld3 = lijn.Substring(40, 1).Trim();
                        veld4 = lijn.Substring(48, 6).Trim();

                        sb.Append($"{veld1,-21}{veld2,-21}{veld3,-5}{veld4,-9}").AppendLine();

                        dicGeg.Add(veld1, veld4);
                    }
                }
                BtnVerwerken.IsEnabled = true;
                TxtResultaat.Text = sb.ToString();
            }
        }

        private void VERWERKEN(object sender, RoutedEventArgs e)
        {
            float resultaat;
            string path = @"..\..\Bestanden";
            StringBuilder sb = new StringBuilder();

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt)|*.txt",
                FilterIndex = 2,
                Title = "Geef een bestandsnaam op",
                OverwritePrompt = true,
                AddExtension = true,
                DefaultExt = "txt",
                FileName = "Verwerkt.txt",
                InitialDirectory = System.IO.Path.GetFullPath(path)
            };

            sfd.ShowDialog();

            using (StreamWriter sw = File.CreateText(sfd.FileName))
            {
                foreach (var item in dicGeg)
                {
                    sb.Append($"{item.Key,-24}");

                    resultaat = float.Parse(item.Value.Substring(0, 3)) / float.Parse(item.Value.Substring(3, 3));
                    sb.Append($"{resultaat,-10:p}");

                    sb.Append((resultaat >= 0.8) ? $"{"Geslaagd",-20}" : $"{"Niet Geslaagd",-20}").AppendLine();

                    sw.WriteLine(sb);
                }
            }
            MessageBox.Show("De resultaten zijn verwerkt. " +
                "Je kan de reusltaten nalezen in het bestand " + sfd.FileName, "Resulaten", MessageBoxButton.OK, MessageBoxImage.Information);

            BtnNalezen.IsEnabled = true;
        }

        private void NALEZEN(object sender, RoutedEventArgs e)
        {
            string path = @"..\..\Bestanden";

            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt)|*.txt",
                InitialDirectory = System.IO.Path.GetFullPath(path),
                Title = "Bestand openen",
                FileName = "Verwerkt.txt"
            };

            TxtResultaat.Clear();
            if (ofd.ShowDialog() == true)
            {
                TxtResultaat.Text = File.ReadAllText(ofd.FileName);
            }
            else
            {
                MessageBox.Show("De resultaten zijn niet verwerkt. ", "Resulaten",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SLUITEN(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
