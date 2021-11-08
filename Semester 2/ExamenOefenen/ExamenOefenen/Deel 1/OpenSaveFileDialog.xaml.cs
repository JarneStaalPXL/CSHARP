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
using Microsoft.Win32;

namespace ExamenOefenen
{
    /// <summary>
    /// Interaction logic for OpenSaveFileDialog.xaml
    /// </summary>
    public partial class OpenSaveFileDialog : Window
    {
        public OpenSaveFileDialog()
        {
            InitializeComponent();

        }

        public static OpenFileDialog ofd = new OpenFileDialog()
        {
            Filter = "Alle bestanden (*.*)|*.*|Tekstbestanden (*.txt) |*.txt",
            FilterIndex = 2,
            FileName = "randomTextPath.txt",
            Multiselect = true,
            InitialDirectory = Environment.CurrentDirectory
        };

        public static SaveFileDialog sfd = new SaveFileDialog()
        {
            FilterIndex = 2,
            Title = "Geef een bestandsnaam op",
            OverwritePrompt = true,
            AddExtension = true,
            DefaultExt = "txt",
            FileName = ofd.FileName,
            InitialDirectory = Environment.CurrentDirectory

        };

        private void LoadFile(object sender, RoutedEventArgs e)
        {
            if (ofd.ShowDialog() == true)
            {
                filePathOutput.Content = string.Empty;
                outputBox.Text = string.Empty;
                foreach (var item in ofd.FileNames)
                {
                    filePathOutput.Content += item + "\n";
                    outputBox.Text += File.ReadAllText(item) + "\n";
                }
                
                //string path = System.IO.Path.GetDirectoryName(ofd.FileName);
                //string[] bestanden = Directory.GetFiles(path);

                //int i = 0;
                //for (; i < bestanden.Length; i++)
                //{
                //    outputBox.Text += $"FilePath {bestanden[i]}\r\n"; 
                //    outputBox.Text += $"FileName {System.IO.Path.GetFileName(bestanden[i])}\r\n"; 
                //    outputBox.Text += "\n";
                //}
                //outputBox.Text += $"Aantal bestanden: {i}";
            }
        }

        private void SaveFile(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(ofd.FileName);
            string text = outputBox.Text;
            string path = $"replacethis.txt";
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write("");
            }

            if (sfd.ShowDialog() == true)
            {
                string text2 = File.ReadAllText(ofd.FileName);
                File.WriteAllText(sfd.FileName, text2);
                
                MessageBox.Show("Succesfully saved");
            }
        }
    }
}
