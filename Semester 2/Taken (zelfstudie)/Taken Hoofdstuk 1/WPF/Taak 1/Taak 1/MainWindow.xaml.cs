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

namespace Taak_1
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

        string filePath = @"tekst.csv";
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
                sw.WriteLine("first field; second field; third field");
            }
        }

        private void Inlezen(object sender, RoutedEventArgs e)
        {
            string[] array;
            using (StreamReader sr = new StreamReader(filePath))
            {
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(';');
                    outputBox.Text += (array[0]+ array[1]+ array[2]+"\n");
                }
            }
        }

        private void Opslaan(object sender, RoutedEventArgs e)
        {
            string changedvalue = outputBox.Text;
            File.WriteAllText(filePath, changedvalue);
        }
    }
}
