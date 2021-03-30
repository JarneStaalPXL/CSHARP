using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CSVExcelExport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // TODO: Seperate List for Belgian & US Stocks (DONE)
    // TODO: A CSV file for Belgian & US Stocks
    // TODO: ComboBox EUR/USD will change the currency and where data will be saved
    public partial class MainWindow : Window
    {
        private string SelectedStockListFile = $@"../../Bestanden/EuropeanStocksList.csv";
        private string SelectedCurrencyCSVFile = $@"../../Bestanden/EuropeanStocks.csv";
        private string EuropeanStocksList = $@"../../Bestanden/EuropeanStocksList.csv";
        private string AmericanStocksList = $@"../../Bestanden/AmericanStocksList.csv";
        private string[] arrayEurope;
        private string[] arrayAmerica;

        private Variables vr = new Variables();
        public MainWindow()
        {
            InitializeComponent();
        }

        #region NotImportant
        private void CloseButton(object sender, RoutedEventArgs e)
        {
            if (outputBox.Text == string.Empty)
            {
                MessageBox.Show("No Stocks Added", "Attention");
                Close();
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(EuropeanStocksList, false))
                {
                    foreach (string s in vr.EuropeanStockList)
                        sw.WriteLine(s);
                }

                using (StreamWriter sw = new StreamWriter(AmericanStocksList, false))
                {
                    foreach (string s in vr.AmericanStockList)
                        sw.WriteLine(s);
                }
                MessageBox.Show("Stocks Successfully Converted!", "Successful");
                Close();
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        #endregion

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region SomeMoreIfStatements
            if (!File.Exists(@"../../Bestanden"))
                Directory.CreateDirectory(@"../../Bestanden");

            if (!File.Exists(SelectedCurrencyCSVFile))
                GenerateTopColumns(sender, e);

            if (!File.Exists(EuropeanStocksList))
            {
                foreach (string stock in vr.BackupEuropeanStocksList)
                {
                    using (StreamWriter sw = new StreamWriter(EuropeanStocksList, true))
                    {
                        sw.WriteLine(stock);
                    }
                }
            }

            if (!File.Exists(AmericanStocksList))
            {
                foreach (string stock in vr.BackupAmericanStocksList)
                {
                    using (StreamWriter sw = new StreamWriter(AmericanStocksList, true))
                    {
                        sw.WriteLine(stock);
                    }
                }
            }
            #endregion

            comboboxCurrency.SelectedIndex = 0;
            stockname.Focus();

            #region Timers
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.dateLabel.Content = $"{DateTime.Now.ToString("dd-MM-yyyy")}";
            },
            this.Dispatcher);

            DispatcherTimer timer2 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("HH:mm:ss")}";
            },
            this.Dispatcher);
            #endregion
        }

        

        private void Add_Button(object sender, RoutedEventArgs e)
        {
            Processing();
        }

        private void OpenFile(object sender, RoutedEventArgs e)
        {
            if (File.Exists(SelectedCurrencyCSVFile))
                Process.Start("excel", SelectedCurrencyCSVFile);
            else
                MessageBox.Show("File does not exist. Please add a stock first.", "Failed Opening File");
        }

        private void StockComboBoxChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (stockComboBox.SelectedValue == null)
                stockComboBox.SelectedItem = 0;
            else
                stockname.Text = stockComboBox.SelectedValue.ToString();

        }

        private void GenerateTopColumns(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(SelectedCurrencyCSVFile, true))
            {
                sw.WriteLine();
            }

            var content = File.ReadAllText(SelectedCurrencyCSVFile, Encoding.UTF8);
            content = $"STOCK;AMOUNT;PRICE;TOTAL PRICE\n{content}";
            File.WriteAllText(SelectedCurrencyCSVFile, content, Encoding.UTF8);
        }

        private void comboboxCurrency_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (comboboxCurrency.SelectedIndex == 0)
            {
                SelectedCurrencyCSVFile = $@"../../Bestanden/EuropeanStocks.csv";
                SelectedStockListFile = $@"../../Bestanden/EuropeanStocksList.csv";
                vr.EuropeanStockList.Clear();
                stockComboBox.Items.Clear();
                using (StreamReader sr = new StreamReader(SelectedStockListFile))
                {
                    while (!sr.EndOfStream)
                    {
                        arrayEurope = sr.ReadLine().Split('\n');
                        vr.EuropeanStockList.Add(arrayEurope[0]);
                    }
                    foreach (string stock in vr.EuropeanStockList)
                    {
                        stockComboBox.Items.Add(stock);
                    }
                }
            }
            else if (comboboxCurrency.SelectedIndex == 1)
            {
                SelectedCurrencyCSVFile = $@"../../Bestanden/AmericanStocks.csv";
                SelectedStockListFile = $@"../../Bestanden/AmericanStocksList.csv";
                vr.AmericanStockList.Clear();
                stockComboBox.Items.Clear();
                using (StreamReader sr = new StreamReader(SelectedStockListFile))
                {
                    while (!sr.EndOfStream)
                    {
                        arrayAmerica = sr.ReadLine().Split('\n');
                        vr.AmericanStockList.Add(arrayAmerica[0]);
                    }
                    foreach (string stock in vr.AmericanStockList)
                    {
                        stockComboBox.Items.Add(stock);
                    }
                }
            }
        }

        private void Processing()
        {
            vr.StockName = stockname.Text;
            vr.AmountOfStockBought = float.Parse(amountofstockbought.Text);
            vr.BoughtAtStockPrice = float.Parse(boughtatstockprice.Text);

            #region IfElses
            if (comboboxCurrency.SelectedIndex == 0)
                vr.Currency = "€ ";
            else if (comboboxCurrency.SelectedIndex == 1)
                vr.Currency = "$ ";
            #endregion

            #region Content
            outputBox.Text = $"\nSuccessfully added\n\nStock\n{vr.StockName}\n\nAmount\n{vr.AmountOfStockBought}\n\n" +
            $"Price\n{vr.Currency}{vr.BoughtAtStockPrice}\n\nTotal Price\n{vr.Currency}{vr.TotalPrice()}";

            AddButton.Content = "ADD";
            stockname.Text = string.Empty;
            amountofstockbought.Text = string.Empty;
            boughtatstockprice.Text = string.Empty;
            stockname.Focus();
            #endregion

            #region Validation
            if (outputBox.Text == string.Empty)
                MessageBox.Show("No Stocks Added", "Attention");
            else
            {
                using (StreamWriter sw = new StreamWriter(SelectedCurrencyCSVFile, true, Encoding.UTF8))
                {
                    sw.WriteLine($"{vr.StockName};{vr.AmountOfStockBought};" +
                    $"{vr.Currency} {vr.BoughtAtStockPrice};" +
                    $"{vr.Currency} {vr.TotalPrice()}");
                }
            }
            #endregion
        }


        private void Validation()
        {

        }
    }
}