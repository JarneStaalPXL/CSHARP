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
        

        private string shipment = "";
        private string delcomp = "";
        private string license = "";

        public MainWindow()
        {
            InitializeComponent();
        }  


        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {


            shipment = Shipment.Text;
            delcomp = DDelcomp.Text;
            license = License.Text;


            DateTime date2 = DateTime.Now;
            InfoLabel.Content = $"------------------USER INFO------------------ \n{date2.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n"
                 + $"Shipment \n {shipment}\n "
                 + $"Delivery Company \n {delcomp} \n"
                 + $"License Plate \n {license} \n";

            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "Database");
            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");
            System.IO.Directory.CreateDirectory(dbPath);

            StreamWriter writer = new StreamWriter(inputFile, true);
            DateTime date1 = DateTime.Now;
            writer.WriteLine($"------------------USER INFO------------------ \n{date1.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n");
            for (int j = 0; j < 1; j++)
            {
                writer.WriteLine($"Shipment Number \n  {shipment}\n");
                writer.WriteLine($"Delivery Company \n  {delcomp}\n");
                writer.WriteLine($"License Plate \n  {license}\n");
                writer.WriteLine("------------------------------------");
            }
            writer.Close();

            int teller = 1;
            teller++;

            Process explorer = new Process();
            Process.Start("IExplore.exe", "https://www.scania.com/");

            if (teller ==10)
            {
                MessageBox.Show("If Werkt");
                Process notepad = new Process();
                Process.Start("notepad", @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\HomeProjects\WPF\FinalUserReg\test\bin\Debug\Database\SubmittedUserInfo.txt");
            }
        }
    }
}