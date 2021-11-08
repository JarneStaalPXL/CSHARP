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

namespace ExamenOefenen.Oefeningenbundel.Oefening_3_PuntenBestand
{
    /// <summary>
    /// Interaction logic for PuntenBestand.xaml
    /// </summary>
    public partial class PuntenBestand : Window
    {
        public PuntenBestand()
        {
            InitializeComponent();
        }

        private string path = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Oefeningenbundel\Oefening 3 PuntenBestand\Punten.txt";

        private void Inlezen_Click(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string[] array;
                while (!sr.EndOfStream)
                {
                    TxtResultaat.Text += sr.ReadLine()+ Environment.NewLine;
                }
            }
        }

        private void Verwerken_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.OverwritePrompt = true;

        }

        private void Nalezen_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Sluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
