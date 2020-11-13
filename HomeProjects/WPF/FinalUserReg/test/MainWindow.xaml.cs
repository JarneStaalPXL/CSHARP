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
using System.Timers;
using System.Security.Cryptography;
using shipmentregistrator;
using System.Windows.Threading;

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
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("d")}\n{DateTime.Now.ToString("HH:mm:ss")}";
            }, 
            this.Dispatcher);

            //DispatcherTimer dispatcher = new DispatcherTimer();

            //// Installeren van timer dmv de klasse aan te spreken.
            //DispatcherTimer wekker = new DispatcherTimer();
            //// Timer laten aflopen om de seconde.
            //wekker.Tick += new EventHandler(DispatcherTimer_Tick);
            //wekker.Interval = new TimeSpan(0, 0, 1);
            ////uren, minuten, seconden
            //// Timer laten starten
            //wekker.Start();
            //// TIJD instellen.
            //DateTime time = DateTime.Now;
            //timeLabel.Content = $"{time.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
        }

        
        private void NameInputButton_Click(object sender, RoutedEventArgs e)
        {

            

            shipment = Shipment.Text;
            delcomp = DDelcomp.Text;
            license = License.Text;


            DateTime date2 = DateTime.Now;
            InfoLabel.Content = $"------------------SHIPMENT INFO------------------ {date2.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n"
                 + $" Shipment \n {shipment}\n "
                 + $"Delivery Company \n {delcomp} \n"
                 + $" License Plate \n {license} \n";

            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "DATABASE");
            string inputFile = System.IO.Path.Combine(dbPath, "SHIPMENTS.txt");
            System.IO.Directory.CreateDirectory(dbPath);

            StreamWriter writer = new StreamWriter(inputFile, true);
            DateTime date1 = DateTime.Now;
            writer.WriteLine($"------------------SHIPMENT INFO------------------ \n{date1.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n");
            for (int j = 0; j < 1; j++)
            {
                writer.WriteLine($"Shipment Number \n  {shipment}\n");
                writer.WriteLine($"Delivery Company \n  {delcomp}\n");
                writer.WriteLine($"License Plate \n  {license}\n");
                writer.WriteLine("------------------------------------");
            }
            writer.Close();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            Process Explorer = new Process();
            Process.Start("chrome.exe", "https://www.scania.com/be/nl/home.html");
        }

        private void regshipments_Click(object sender, RoutedEventArgs e)
        {
            Process notepad = new Process();
            Process.Start("notepad", Directory.GetCurrentDirectory() + $@"\DATABASE\SHIPMENTS.txt");
        }

        

        private void testing(object sender, RoutedEventArgs e)
        {

            //this.Content = new Uri("Clients.xaml", UriKind.Relative);
            //Page Page1 = ;
            //NavigationService nav = NavigationService.GetNavigationService(Page1);
                Window newWindow = new Client();
                newWindow.Show();
                this.Close();
            }
        }
    }   