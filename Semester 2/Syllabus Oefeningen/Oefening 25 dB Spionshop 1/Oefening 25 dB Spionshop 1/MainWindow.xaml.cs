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

namespace Oefening_25_dB_Spionshop_1
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string con =
                @"Provider = SQLOLEDB.1; Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = Spionshop;
                Data Source = DESKTOP - 7TSFPEJ\SQLEXPRESS";

            using (SqlConnection cnn = new SqlConnection(con))
            {

            }


        }


        private void BtnAddClick(object sender, RoutedEventArgs e)
        {

        }

        private void BtnUpdateClick(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
