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
    /// Interaction logic for FileStreamReadWrite.xaml
    /// </summary>
    public partial class FileStreamReadWrite : Window
    {
        public string[] array;
        public FileStreamReadWrite()
        {
            InitializeComponent();
        }

        private void ReadCSVWithFileStream(object sender, RoutedEventArgs e)
        {
            //Clearing textbox so file reads don't append
            outputBox.Text = "";

            //A FileStream is a way to use a file with settings.
            //Page 5 in Syllabus
            using (FileStream fsRead = new FileStream(CSVDetails.filePath, FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fsRead))
                {
                    while (!sr.EndOfStream)
                    {
                        array = sr.ReadLine().Split(';');
                        outputBox.Text += $"{array[0]} {array[1]}\n";
                    }
                }
            }
        }

        private void WriteCSVWithFileStream(object sender, RoutedEventArgs e)
        {
            using (FileStream fsWrite = new FileStream(CSVDetails.filePath, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fsWrite))
                {
                    sw.WriteLine($"{outputBox.Text};");
                }
            }
        }
    }
}
