using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefening_2_StringZoekenBestand
{
    /// <summary>
    /// Interaction logic for StringZoekenBestand.xaml
    /// </summary>
    public partial class StringZoekenBestand : Window
    {
        private string path = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Oefeningenbundel\Oefening 2 StringZoekenBestand\Email.txt";
        public StringZoekenBestand()
        {
            InitializeComponent();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private string pathFileName = "";
        private void Bladeren_Click(object sender, RoutedEventArgs e)
        {
            

            try
            {
                ofd.ShowDialog();
                pathFileName = System.IO.Path.GetFileName(ofd.FileName);
                pathBox.Text = pathFileName;
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show(ae.ToString());
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show(fe.ToString());
            }
            catch (UnauthorizedAccessException unauthAE)
            {
                MessageBox.Show(unauthAE.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OutputData(string searchedStr)
        {
            TxtResultaat.Text = string.Empty;
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                string line;
                int regel = 0;
                int aantalRegels = 0;
                while (!sr.EndOfStream)
                {
                    aantalRegels++;
                    line = sr.ReadLine();

                    if (line.Contains(searchedStr, StringComparison.OrdinalIgnoreCase))
                    {
                        regel++;
                        TxtResultaat.Text += $"{pathFileName}: regel : {regel} - {line}\n";
                    }
                }

                TxtResultaat.Text += $"\n\n{searchedStr} gevonden in {regel} regels (totaal {aantalRegels} regels).";
            }
        }

        private void Zoeken_Click(object sender, RoutedEventArgs e)
        {
            string searchedStr = searchedString.Text;
            OutputData(searchedStr);
        }

        private void searchedString_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchedStr = searchedString.Text;
            OutputData(searchedStr);
        }
    }
}
