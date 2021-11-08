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

namespace ExamenOefenen
{
    /// <summary>
    /// Interaction logic for FileInfoWriting.xaml
    /// </summary>
    public partial class FileInfoWriting : Window
    {
        public FileInfoWriting()
        {
            InitializeComponent();
        }

        FileInfo fi = new FileInfo(FileInfoCSVDetails.PathCSV);
        FileInfo fi2 = new FileInfo(@"Times.txt");

        private void FileInfoReader(object sender, RoutedEventArgs e)
        {
            

            using (StreamWriter sw = new StreamWriter(FileInfoCSVDetails.PathCSV))
            {
                sw.Write("");
            }
            

            if (fi.Exists)
            {
                if (MessageBox.Show($"Do you want to delete the file {fi.Name}?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    fi.Delete();
                    WriteDate(fi2);
                }
            }
        }

        private void WriteDate(FileInfo fi2)
        {
            Random rand = new Random();
            using (StreamWriter sw = new StreamWriter(fi2.Name, true))
            {
                sw.WriteLine(DateTime.Now.ToString("HH:mm"));
            }
            Process.Start("notepad", fi2.Name);
        }

        private void FileInfoStreamReader(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = fi2.OpenText())
            {
                TxtResultaat.Text = sr.ReadToEnd();
            }
        }
    }
}
