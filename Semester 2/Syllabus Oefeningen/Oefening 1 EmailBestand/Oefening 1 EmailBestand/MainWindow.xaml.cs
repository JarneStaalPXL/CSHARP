using Microsoft.Win32;
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

namespace Oefening_1_EmailBestand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> dicGeg = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private StringBuilder InlezenBestand(string bestandsnaam)
        {
            StringBuilder sb = new StringBuilder();
            string[] velden;

            try
            {
                using (StreamReader sr = new StreamReader(bestandsnaam))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {

                        velden = sr.ReadLine().Split(',');

                        if (velden.Length!=2)
                        {
                            MessageBox.Show($"Onvolledige gegvens bij lijn {i}");
                        }
                        else
                        {
                            sb.Append($"{velden[0].Replace("\"", ""),-20} : " +
                                $"{velden[1].Replace("\"", "")}").AppendLine();
                        }
                        i++;
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Geef nieuwe naam!\n\n" + ex.Message, "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            catch (Exception)
            {
                MessageBox.Show("Probleem met het inlezen van het bestand.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            return sb;
           
        }

        private void Inlezen(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = InlezenBestand(@"..\..\Bestanden\Email.Txt");

            if (sb.Length != 0)
            {
                txtResultaat.Text = sb.ToString();
            }
        }

        private void dialogInlezen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Alle bestanden (*.*) | *.* | Tekstbestanden (*.txt) |*.txt",
                FilterIndex = 2,
                FileName = "Email.txt",
                InitialDirectory = Environment.CurrentDirectory
            };

            if (openFileDialog.ShowDialog() == true)
            {
                StringBuilder sb = InlezenBestand(openFileDialog.FileName);

                if (sb.Length != 0)
                {
                    txtResultaat.Text = sb.ToString();
                }
            }

        }

        private void dictionRead(object sender, RoutedEventArgs e)
        {
            
            string[] velden;

            try
            {
                using (StreamReader sr = new StreamReader(@"..\..\Bestanden\Email.txt"))
                {
                    int i = 1;
                    while (!sr.EndOfStream)
                    {

                        velden = sr.ReadLine().Split(',');

                        if (velden.Length != 2)
                        {
                            MessageBox.Show($"Onvolledige gegvens bij lijn {i}");
                        }
                        else
                        {
                            dicGeg.Add(velden[0].Replace("\"", ""), velden[1].Replace("\"", ""));
                        }
                        i++;
                    }
                }


                foreach (var item in dicGeg)
                {
                    txtResultaat.Text += $"{item.Key,-20}: {item.Value}\n";
                }
                BtnWegSchrijven.IsEnabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Kan het bestand niet wegschrijven.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }


        }

        private void Toevoegen(object sender, RoutedEventArgs e)
        {
            string naam = naamBox.Text;
            string email = EmailBox.Text;
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            StringBuilder Sb = new StringBuilder();            

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == true)
            {
                if ((saveFileDialog1.OpenFile()) != null)
                {
                    //string tekst = File.ReadAllText(saveFileDialog1.FileName);
                    StreamWriter sw = new StreamWriter("Email.txt");

                    Sb.Append(naam);
                    Sb.Append(""+ email);

                    sw.WriteLine(Sb.ToString());


                    sw.Close();
                }
            }
        }
    }
}
