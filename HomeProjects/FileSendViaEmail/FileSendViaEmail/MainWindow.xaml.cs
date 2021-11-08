using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace FileSendViaEmail
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

        //Creating a public link to the class Clients because we don't want Clients to be static
        public Clients client = new Clients();

        //Creating OpenFileDialog to choose a file and use it for multiple purposes.
        public OpenFileDialog ofd = new OpenFileDialog();
        

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //When Window Loads, first item will be selected to prevent empty selection
            clientsBox.SelectedIndex = 0;

            //Adding clienst to Combobox
            clientsBox.Items.Add("Youri");
            clientsBox.Items.Add("Jarne");

            
        }

        private void SendEmail(object sender, RoutedEventArgs e)
        {
            //Checking if no clients are selected
            //If a client is selected, it will send a trading report to that user
            if (clientsBox.SelectedIndex < 0)
            {
                MessageBox.Show("No client selected");  
            }
            else
            {
                client.SendMail(msgBox.Text, ofd.FileName);
            }
        }



        private void clientsBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (clientsBox.SelectedIndex >= 0)
            {
                //Checking what client to send the report
                if (clientsBox.SelectedItem.Equals("Youri"))
                {
                    client.sendToEmail = client.Youri;
                    ofd.FileName = @"F:\Trading\YouriDayTrading.xlsx";
                    fileButton.Content = ofd.FileName;
                }
                else if (clientsBox.SelectedItem.Equals("Jarne"))
                {
                    client.sendToEmail = client.Jarne;
                    ofd.FileName = @"F:\Trading\DayTrading.xlsx";
                    fileButton.Content = ofd.FileName;
                }
                   

                //Displaying the email of the user 
                emailOutput.Content = client.sendToEmail;


                //Splitting the email in parts so msgBox doesn't contain html tags
                client.one = $"Beste {clientsBox.SelectedItem}";
                client.two = "In bijlage het handelsrapport van vandaag.";
                client.three = "Met vriendelijke groeten";


                //Displaying the email body perfectly 
                msgBox.Text = $"Beste {clientsBox.SelectedItem}\n\n" +
                $"In bijlage het handelsrapport van vandaag.\n\n" +
                $"Met vriendelijke groeten";
            }
        }
    }
}
