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

namespace ExamenOefenen.Voorbeeldexamen
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

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt)|*.txt",
                FileName = "Studenten_toepassing.csv",
                Multiselect = true,
                InitialDirectory = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Voorbeeldexamen",
            };
            if (ofd.ShowDialog() == true)
            {
                Databank.DataFolder = System.IO.Path.GetDirectoryName(ofd.FileName);
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string[] array;
                    while (!sr.EndOfStream)
                    {
                        array = sr.ReadLine().Split(';');
                        string code = array[2];

                        Vak vak = new Vak(code);

                        Student stud = new Student(array);
                        Databank.ListStudenten.Add(stud);

                        studentenLBx.Items.Add($"{array[0]} {array[1]} - {array[2]} ({vak.Omschrijving})");
                    }
                }
            }
            // Vakken vullen
            foreach (var item in Databank.DictVakken)
            {
                Vak vk = new Vak(item.Key, item.Value);
            }
        }

        private void studentenLBx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = studentenLBx.SelectedIndex;
            MessageBox.Show(
                $"{Databank.ListStudenten[index].Voornaam.Substring(0, 1)}. " +
                $"{Databank.ListStudenten[index].Naam} volgt les in de afdeling {Databank.ListStudenten[index].VakVolledig.ToUpper()}", 
                "Info student");
        }

        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void OpenDataOverzicht_Click(object sender, RoutedEventArgs e)
        {
            DataOverzicht dataoverzicht = new DataOverzicht();
            dataoverzicht.Show();
        }

        private void OpslaanCSV_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Comma Seperated File (*.csv)|*.csv",
                FilterIndex = 2,
                Title = "Geef een bestandsnaam op",
                OverwritePrompt = true,
                AddExtension = true,
                FileName = "studentenSaved.csv",
                InitialDirectory = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Voorbeeldexamen",
            };

            if (sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Student student in Databank.ListStudenten)
                    {
                        sw.WriteLine($"{student.Naam};{student.Voornaam};{student.VakVolledig}");
                    }
                }
            }
        }

        private void OpslaanData(object sender, RoutedEventArgs e)
        {
            if (Databank.DataFolder != string.Empty)
            {
                string dataBestand = $"{Databank.DataFolder}\\data.xml";
                Databank.DsStudent.WriteXml(dataBestand);
                MessageBox.Show($"You can find the saved XML in this path\n{dataBestand}","Saved succesfully");
            }

            
        }
    }
}
