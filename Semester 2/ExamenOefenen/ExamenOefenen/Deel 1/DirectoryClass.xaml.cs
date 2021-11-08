using Microsoft.Win32;
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
    /// Interaction logic for DirectoryClass.xaml
    /// </summary>
    public partial class DirectoryClass : Window
    {
        public DirectoryClass()
        {
            InitializeComponent();
        }

        private void ShowFoldersFiles(object sender, RoutedEventArgs e)
        {
            foldersLbl.Items.Clear();
            filesLbl.Items.Clear();
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string path = pathTxt.Text;

            // Toont alle bestandsnamen
            if (Directory.Exists(path))
            {
                string[] bestanden = Directory.GetFiles(path);
                foreach (string file in bestanden)
                {
                    filesLbl.Items.Add(file);
                }
                // Toont alle mappen
                string[] mappen = Directory.GetDirectories(path);
                foreach (string dir in mappen)
                {
                    foldersLbl.Items.Add(dir);
                }
            }
            else
            {
                MessageBox.Show("PATH INCORRECT/NOT FOUND");
            }
        }

        private void filesLbl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (filesLbl.SelectedIndex > -1)
            {
                Process.Start("notepad", filesLbl.SelectedItem.ToString());
            }
            
        }
    }
}
