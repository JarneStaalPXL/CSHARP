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

namespace euroDollar
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

        private void Button_Click_Berekenen(object sender, RoutedEventArgs e)
        {
            string eurosTekst = euroTextBox.Text;
            double euros = Convert.ToDouble(eurosTekst);
            double dollar = euros * 1.18;
            dollarLabel.Content = dollar;
        }

        private void Button_Click_Wissen(object sender, RoutedEventArgs e)
        {
            dollarLabel.Content = "";
            euroTextBox.Text = "";
        }
    }
}
