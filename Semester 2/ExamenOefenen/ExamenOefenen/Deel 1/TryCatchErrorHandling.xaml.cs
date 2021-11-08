using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen
{
    /// <summary>
    /// Interaction logic for TryCatchErrorHandling.xaml
    /// </summary>
    public partial class TryCatchErrorHandling : Window
    {
        public TryCatchErrorHandling()
        {
            InitializeComponent();
        }

        private void TryParsebtnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double number2 = double.Parse(inputBox.Text);
               
                MessageBox.Show("Succesfully parsed", number2.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
