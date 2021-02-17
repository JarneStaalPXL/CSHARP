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

namespace Oefening_1_EmailBestand
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Dictionary<string, string> dicGeg = new Dictionary<string, string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Inlezen(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string pad = @"..\..\Bestanden\Email.txt";
            sb.Append(File.ReadAllText(pad));

            txtResultaat.Text = sb.ToString();
        }

        private void dialogInlezen(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            txtResultaat.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void dictionRead(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            string pad = File.ReadAllText(openFileDialog.FileName);

            using (var sr = new StreamReader(pad))
            {
                string line = null;

                // while it reads a key
                while ((line = sr.ReadLine()) != null)
                {
                    // add the key and whatever it 
                    // can read next as the value
                    dicGeg.Add(line, sr.ReadLine());
                }
            }


            txtResultaat.Text = dicGeg.ToString() ;
            
        }
    }
}
