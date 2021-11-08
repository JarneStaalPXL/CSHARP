using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace ExamenOefenen.Oefeningenbundel.Oefening_1_Emailbestand
{
    /// <summary>
    /// Interaction logic for EmailBestand.xaml
    /// </summary>
    public partial class EmailBestand : Window
    {
        
        private Dictionary<string, string> dicGeg = new Dictionary<string, string>();
        public EmailBestand()
        {
            InitializeComponent();
        }

        private void BtnInlezen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = string.Empty;

            //string text = File.ReadAllText(path).Trim('"',' ');
            //TxtResultaat.Text = text;
            string path = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Oefeningenbundel\Oefening 1 Emailbestand\Email.txt";
            InlezenBestand(path);
        }

        private void BtnInlezenDialog_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            InlezenBestand(ofd.FileName);
        }

        /// <summary>
        /// Reads a comma seperated file
        /// </summary>
        /// <param name="path">Path</param>
        void InlezenBestand(string path)
        {
            TxtResultaat.Text = string.Empty;
            using (StreamReader sr = new StreamReader(path, Encoding.UTF8))
            {
                string[] array;
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(',');
                    TxtResultaat.Text += $"{array[0].Replace('"', ' '),-30} : {array[1].Replace('"', ' ')}\n";
                }
            }
        }

        private void BtnInlezenDictionary_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = string.Empty;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.UTF8))
            {
                string[] array;
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(',');
                    TxtResultaat.Text += $"{array[0].Replace('"', ' '),-30} : {array[1].Replace('"', ' ')}\n";

                    dicGeg.Add(array[0].Replace('"', ' '), array[1].Replace('"', ' '));
                }
            }

            foreach (var item in dicGeg)
            {
                Debug.WriteLine(item);
            }
            BtnWegschrijven.IsEnabled = true;
        }

        private void BtnWegschrijven_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Adressen.txt";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            sfd.AddExtension = true;

            sfd.ShowDialog();

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                foreach (var item in dicGeg.Values)
                {
                    sw.WriteLine(item);
                }
            }
        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = string.Empty;
            string naam = TxtNaam.Text;
            string emailAdres = TxtEmailadres.Text;

            string path = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Oefeningenbundel\Oefening 1 Emailbestand\Email.txt";
            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine($"\n\"{naam}\",\"{emailAdres}\" ");
                dicGeg.Add(naam, emailAdres);
            }

            InlezenBestand(path);
        }
    }
}
