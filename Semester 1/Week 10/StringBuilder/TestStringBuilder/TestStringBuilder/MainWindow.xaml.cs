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

namespace TestStringBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            result.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            txtBox1.Visibility = Visibility.Hidden;
            txtBox2.Visibility = Visibility.Hidden;
            result.Visibility = Visibility.Visible;


            StringBuilder sb = new StringBuilder();

            string score1 = txtBox1.Text;
            string score2 = txtBox2.Text;
            


            sb.AppendLine($"Score 1 = {score1}");
            sb.AppendLine($"Score 2 = {score2}");

            result.Text = $"{sb}";
        }

        private void txtBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtBox1.Visibility = Visibility.Hidden;
        }
    }
}
