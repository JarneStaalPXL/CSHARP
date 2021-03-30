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

namespace CSVClasses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string path = @"..\..\Bestanden";
        private string pathTxt = @"..\..\Bestanden\users.txt";
        public MainWindow()
        {
            InitializeComponent();
            Directory.CreateDirectory(path);
        }

        private StringBuilder sb = new StringBuilder();
        
        private void Inlezen(object sender, RoutedEventArgs e)
        {
            string[] array;
            Users user = new Users();
            using (StreamReader sr = new StreamReader(pathTxt))
            {
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(';');
                    outputBox.Text += $"Naam: {array[1],-15} Voornaam: {array[0]}\n";
                }
            }
        }
    }
}
