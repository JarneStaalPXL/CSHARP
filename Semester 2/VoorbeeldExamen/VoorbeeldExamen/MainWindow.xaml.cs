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

namespace VoorbeeldExamen
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
                Multiselect = false,
                InitialDirectory = @"C:\Studenten_toepassing.csv"
            };

            if (ofd.ShowDialog() == true)
            {
                DataBank.DataFolder = System.IO.Path.GetDirectoryName(ofd.FileName);

                string[] kolommen;
                Student stud;
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {        
                    while (!sr.EndOfStream)
                    {
                        kolommen = sr.ReadLine().Split(';');
                        //stud = new Student(kolommen);
                        DataBank.listStudenten.Add(new Student(kolommen));
                    }
                }
                lstStudent.ItemsSource = DataBank.listStudenten;
            }
        }

        private void lstStudent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student info = DataBank.listStudenten[lstStudent.SelectedIndex];
            MessageBox.Show($"{info.Voornaam.Substring(0,1)}. {info.Naam} volgt les in afdeling {info.VakVolledig.ToUpper()}","Info student");
        }

        private void MenuAfsluiten_Click(object sender, SelectionChangedEventArgs e)
        {
            //Application.Current.Shutdown();
            Close();
        }

        private void Opslaan_CSV_Click(object sender, SelectionChangedEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*csv)|*.csv",
                FilterIndex = 2,
                Title = "Geef CSV export op",
                OverwritePrompt = true,
                AddExtension = true,
                InitialDirectory = DataBank.DataFolder
            };
            if (sfd.ShowDialog() == true)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    foreach (Student s in DataBank.listStudenten)
                    {
                        sw.WriteLine($"{s.Naam};{s.Voornaam};{s.VakVolledig}");
                    }
                }
            }
        }
        
        
        
        private void Opslaan_XML_Click(object sender, SelectionChangedEventArgs e)
        {
            DataBank.dsStudent.WriteXml($"{DataBank.DataFolder}\\xmldata.xml");
        }

        private void OverzichtGeg_Click(object sender, SelectionChangedEventArgs e)
        {

        }

    }
}
