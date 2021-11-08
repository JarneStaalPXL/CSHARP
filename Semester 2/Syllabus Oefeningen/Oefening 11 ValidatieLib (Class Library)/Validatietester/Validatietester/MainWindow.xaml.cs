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
using ValidatieLib;

namespace Validatietester
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
       
        private void TestBtn_Click(object sender, RoutedEventArgs e)
        {
            ouputLbl.Content = string.Empty;

            if (Validatie.IsAanwezig(TxtIntGetal) && 
                Validatie.IsAanwezig(TxtDecGetal) &&
                Validatie.IsInteger(TxtIntGetal) && 
                Validatie.IsDecimal(TxtDecGetal)) 
            {
                ouputLbl.Content = "Tekstvakken zijn correct ingevuld.";
            }
            else
            {
                ouputLbl.Content = "Tekstvakken zijn niet correct ingevuld.";
            }


        }
    }
}
