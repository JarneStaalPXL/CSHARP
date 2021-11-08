using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
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
    /// Interaction logic for FileClass.xaml
    /// </summary>
    public partial class FileClass : Window
    {
        public FileClass()
        {
            InitializeComponent();
        }

        private void FileAppendText(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = File.AppendText(CSVDetails.filePath))
            {
                sw.WriteLine("Jacky Staal;");
            }
            MessageBox.Show("Text has been appended to given path");
        }

        private void FileCreate(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            string randomPath = $@"NoUse{rand.Next(0,99)}.txt";
            File.Create(randomPath);

            MessageBox.Show("Random file is created");

        }

        private void FileCreateText(object sender, RoutedEventArgs e)
        {
            // WILL OVERWRITE FILE
            // Use this to write UTF8 encoded 
            // It's possible to use normal StreamWriter with UTF8 encoding if you pass the Encoding but not recommended
            using (StreamWriter sw = File.CreateText(CSVDetails.filePath))
            {
                sw.WriteLine("Caro Meyers;");
                sw.WriteLine("Bob Ross;");
                sw.WriteLine("Peter Pan;");
            }

            MessageBox.Show("Overwritten given filepath with hardcoded data");
        }

        private void FileDelete(object sender, RoutedEventArgs e)
        {

            Process.Start("explorer.exe", CSVDetails.DebugPath);
            MessageBox.Show("Please first create this file manually to then click this button to delete it");   
            MessageBox.Show("File has been deleted");
            File.Delete($"NoUse55.txt");

        }

        private void FileCopy(object sender, RoutedEventArgs e)
        {
            // To copy files under a different name
            File.Copy(CSVDetails.filePath, $"Copied {CSVDetails.filePath}");
        }

        private void FileExists(object sender, RoutedEventArgs e)
        {
            if (File.Exists(CSVDetails.filePath))
            {
                MessageBox.Show(CSVDetails.filePath + " exists");
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(CSVDetails.filePath))
                {
                    sw.WriteLine("Caro Meyers;");
                    sw.WriteLine("Bob Ross;");
                    sw.WriteLine("Peter Pan;");
                }
            }
        }

        private void FileOpenText(object sender, RoutedEventArgs e)
        {
            //Reads file UTF8 Encoded
            using (StreamReader sr = File.OpenText(CSVDetails.filePath))
            {
                sr.ReadToEnd();
            }
        }

        private void FileReadAllLines(object sender, RoutedEventArgs e)
        {
            contentLbl.Content = string.Empty;
            string[] array = File.ReadAllLines(CSVDetails.filePath);

            foreach (var item in array)
            {
                contentLbl.Content += item.Remove(item.Length - 1) + "\n";
            }
        }

        private void FileReadAllLinesLength(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"There are currently {File.ReadAllLines(CSVDetails.filePath).Length} names in this file");
        }

        private void FileReadAllText(object sender, RoutedEventArgs e)
        {
            contentLbl.Content = File.ReadAllText(CSVDetails.randomTextPath);
        }

        private void FileWriteAllText(object sender, RoutedEventArgs e)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,\n" +
                " sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.\n " +
                "Nulla at volutpat diam ut venenatis. Elementum eu facilisis sed odio\n " +
                "morbi quis commodo. Pulvinar sapien et ligula ullamcorper malesuada.\n";

            //This will overwrite the file if it exists with text or create the file with given text
            File.WriteAllText(CSVDetails.randomTextPath, text);
            contentLbl.Content = File.ReadAllText(CSVDetails.randomTextPath);
        }

        private void FileAppendAllText(object sender, RoutedEventArgs e)
        {
            contentLbl.Content = string.Empty;
            string appendText = "This is extra text" + "\n";
            File.AppendAllText(CSVDetails.randomTextPath, appendText);
            contentLbl.Content = File.ReadAllText(CSVDetails.randomTextPath);
            
        }
    }
}
