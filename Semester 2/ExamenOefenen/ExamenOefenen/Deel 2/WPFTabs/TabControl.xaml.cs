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

namespace ExamenOefenen.Deel_2.WPFTabs
{
    /// <summary>
    /// Interaction logic for TabControl.xaml
    /// </summary>
    public partial class TabControl : Window
    {
        public TabControl()
        {
            InitializeComponent();
        }

        private string pathText = @"randomTextPath.txt";
        private SaveFileDialog sfd = new SaveFileDialog()
        {
            Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
            FileName = "SavedFile",
            AddExtension = true,
            InitialDirectory = Directory.GetCurrentDirectory()
        };

        private OpenFileDialog ofd = new OpenFileDialog() {
            Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*",
            AddExtension = true,
            FileName = $"randomTextPath",
            InitialDirectory = Directory.GetCurrentDirectory()
        };

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Clear();
            ofd.ShowDialog();

            string[] array;
            using (StreamReader sr = new StreamReader(ofd.FileName))
            {
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split('\n');
                    lstBox.Items.Add(array[0]);
                }
            }
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e)
        {
            string text = string.Empty;

            foreach (string item in lstBox.Items)
            {
                text += $"{item}\n";
            }


            sfd.ShowDialog();

            using (StreamWriter sw = new StreamWriter(sfd.FileName))
            {
                sw.Write(text);
            }
        }
    }
}
