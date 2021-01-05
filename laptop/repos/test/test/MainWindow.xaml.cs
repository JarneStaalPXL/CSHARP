using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using System.IO;
using System.Diagnostics;

namespace test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private string name = "";
        private string adres = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {
            name = MainTextBox.Text;
            adres = adrestextbox.Text;

            InfoLabel.Content = $"{name} \n Registered";

            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "Database");
            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");
            System.IO.Directory.CreateDirectory(dbPath);

            StreamWriter writer = new StreamWriter(inputFile, true);
            DateTime date1 = DateTime.Now;
            writer.WriteLine($"------------------USER INFO------------------ \n{date1.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n");
            for (int j = 0; j < 1; j++)
            {
                writer.WriteLine($"Name: {name}\n");
                writer.WriteLine($"Adress: {adres}\n");
            }
            writer.Close();


            Process myProcess = new Process();
            Process.Start("notepad", @"C:\Users\12001144\source\repos\test\test\bin\Debug\Database\SubmittedUserInfo.txt");
        }
    }
}