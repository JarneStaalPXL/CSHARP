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

namespace ExamenOefenen
{
    /// <summary>
    /// Interaction logic for StreamWriterReader.xaml
    /// </summary>
    public partial class StreamWriterReader : Window
    {
        public StreamWriterReader()
        {
            InitializeComponent();
        }

        public string name1; 
        public string name2; 
        public string name3; 

        void SetNames()
        {
            name1 = nameBox1.Text;
            name2 = nameBox2.Text;
            name3 = nameBox3.Text;
        }

        private void WriteToCSV(object sender, RoutedEventArgs e)
        {
            SetNames();

            if (name1 != string.Empty && name2 != string.Empty && name3 != string.Empty)
            {
                using (StreamWriter sw = new StreamWriter(CSVDetails.filePath, true))
                {
                    sw.WriteLine($"{name1};");
                    sw.WriteLine($"{name2};");
                    sw.WriteLine($"{name3};");
                }
            }
            else
            {
                MessageBox.Show("Vul alle velden in ");
            }

            
        }

        private void ReadCSV(object sender, RoutedEventArgs e)
        {
            outputBox.Items.Clear();
            string[] array;
            using (StreamReader sr = new StreamReader(CSVDetails.filePath))
            {
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(';');
                    outputBox.Items.Add(array[0]);
                }
            }
        }

        private void outputBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string[] arrayText = outputBox.SelectedItem.ToString().Split(' ');
            if (arrayText.Length > 1)
            {
                MessageBox.Show($"First letter of firstname is {arrayText[0].Substring(0, 1)}" +
               $"\nSecond letter of lastname is {arrayText[1].Substring(0, 1)} ", "Info");
            }
            else
            {
                MessageBox.Show($"First letter of firstname is {arrayText[0].Substring(0, 1)}" +
               $"\nDoesn't have lastname", "Info");
            }
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            outputBox.Items.Clear();
            using (StreamWriter sw = new StreamWriter(CSVDetails.filePath))
            {
                sw.Write("");
            }
        }
    }
}
