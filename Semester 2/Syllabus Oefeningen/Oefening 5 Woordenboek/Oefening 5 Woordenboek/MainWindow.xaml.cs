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

namespace Oefening_5_Woordenboek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string bestand = @"..\..\Bestanden\ICTWoordenboek.txt";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] velden;

            if (File.Exists(bestand))
            {
                using (StreamReader sr = new StreamReader(bestand))
                {
                    while (!sr.EndOfStream)
                    {
                        velden = sr.ReadLine().Split('|');

                        Lexicon.ICTEngels.Add(velden[0]);
                        Lexicon.ICTNed.Add(velden[1]);
                        LbxTermen.Items.Add($"{velden[0]} - {velden[1]}");
                    }
                }
            }
        }

        private bool wijzingen = false;
        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Lexicon.ICTEngels.Add(TxtEngels.Text);
            Lexicon.ICTNed.Add(TxtNederlands.Text);

            LbxTermen.Items.Add($"{TxtEngels.Text} - {TxtNederlands.Text}");
            TxtEngels.Clear();
            TxtNederlands.Clear();
            TxtEngels.Focus();


            wijzingen = true;
            using (StreamWriter sw = new StreamWriter(bestand, true))
            {
                sw.WriteLine($"{TxtEngels.Text}|{TxtNederlands.Text}");
            }
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (LbxTermen.SelectedIndex !=-1)
            {
                Lexicon.ICTEngels.RemoveAt(LbxTermen.SelectedIndex);
                Lexicon.ICTNed.RemoveAt(LbxTermen.SelectedIndex);

                LbxTermen.Items.Remove(LbxTermen.SelectedItem);

                wijzingen = true;
            }
            else
            {
                MessageBox.Show("Selecteer een item om te verwijderen.");
            }
           
        }

        private void MnuZoekvenster_Click(object sender, RoutedEventArgs e)
        {
            WindowsZoeken wz = new WindowsZoeken();
            wz.ShowDialog();
        }

        private void MnuAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            AboutBox info = new AboutBox();
            info.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (File.Exists(bestand) && wijzingen == true)
            {
                using (StreamWriter sw = File.CreateText(bestand))
                {
                    for (int i = 0; i < Lexicon.ICTEngels.Count; i++)
                    {
                        sw.WriteLine($"{Lexicon.ICTEngels[i]}|{Lexicon.ICTNed[i]}");
                    }
                }
                MessageBox.Show("Bestand werd bijgewerkt!","Info afsluiten", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            Environment.Exit(0);
        }

    }
}
