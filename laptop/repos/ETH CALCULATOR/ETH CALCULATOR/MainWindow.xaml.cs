using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
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

namespace ETH_CALCULATOR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ClientAsync();



            if (string.IsNullOrEmpty(inputBox.Text))
            {

                walletBox.Content = 3500;
                resultBox.Content = "";
            }

            EventManager.RegisterClassHandler(typeof(TextBox),
                  TextBox.KeyUpEvent,
                  new System.Windows.Input.KeyEventHandler(TextBox_PageUp));

            EventManager.RegisterClassHandler(typeof(TextBox),
                  TextBox.KeyUpEvent,
                  new System.Windows.Input.KeyEventHandler(TextBox_KeyUp));

            EventManager.RegisterClassHandler(typeof(TextBox),
                  TextBox.KeyUpEvent,
                  new System.Windows.Input.KeyEventHandler(TextBox_KeyDown));

            EventManager.RegisterClassHandler(typeof(TextBox),
                  TextBox.KeyUpEvent,
                  new System.Windows.Input.KeyEventHandler(TextBox_PageDown));

        }

        private void TextBox_PageUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.PageUp) return;

            // your event handler here
            e.Handled = true;
            double.TryParse(inputBox.Text, out double ethPrice);
            double endResult = ethPrice + 50;
            inputBox.Text = $"{endResult}";
        }

        private void TextBox_PageDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.PageDown) return;

            // your event handler here
            e.Handled = true;
            double.TryParse(inputBox.Text, out double ethPrice);
            double endResult = ethPrice - 50;
            inputBox.Text = $"{endResult}";
        }

        private void TextBox_KeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Up) return;

            // your event handler here
            e.Handled = true;
            double.TryParse(inputBox.Text, out double ethPrice);
            double endResult = ethPrice + 1;
            inputBox.Text = $"{endResult}";
        }

        private void TextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Down) return;

            // your event handler here
            e.Handled = true;
            double.TryParse(inputBox.Text, out double ethPrice);
            double endResult = ethPrice - 1;
            inputBox.Text = $"{endResult}";
        }

        private void inputBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            double EthValue = 8.33273612;
            double investedValue = 3500;
            double.TryParse(inputBox.Text, out double ethPrice);
            double walletamount = EthValue * ethPrice;
            double gain = walletamount / investedValue;
            double loss = investedValue - walletamount;
            var result = Math.Round((walletamount - investedValue) / investedValue * 100, 0);

            walletBox.Content = (Math.Round(walletamount, 0));



            if (string.IsNullOrEmpty(inputBox.Text))
            {

                walletBox.Content = 3500;
                resultBox.Content = "";
            }
            else if (walletamount - investedValue > 0)
            {
                resultBox.Content = ($"Profit: {Math.Round(walletamount - investedValue, 0)} EUROS \n         {result} %");
            }
            else if (walletamount - investedValue < 0)
            {
                resultBox.Content = ($"Loss: {Math.Round(loss, 0)} EUROS \n           {Math.Round(loss / investedValue * 100)} %");
            }
            
        }


        private void Logo_Click(object sender, RoutedEventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\ProgramFiles(x86)\Google\Chrome\Application\chrome.exe\");
            if (file.Exists == true)
            {
                Process Explorer = new Process();
                Process.Start("chrome.exe", "https://www.bitstamp.net/markets/eth/eur");
            }
            else if (file.Exists == false)
            {
                Process Explorer = new Process();
                Process.Start("msedge.exe", "https://www.bitstamp.net/markets/eth/eur");
            }
        }
        
        private async Task<string> ClientAsync()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("https://api.coingecko.com/api/v3/exchange_rates");
            clientOutput.Content = response;
            return response;
        }
    }
}
