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
    /// Interaction logic for Window1Show.xaml
    /// </summary>
    public partial class Window1Show : Window
    {
        public Window1Show()
        {
            InitializeComponent();
        }

        private void W2Show(object sender, RoutedEventArgs e)
        {
            Windows.w2.Show();
        }

        private void SWR(object sender, RoutedEventArgs e)
        {
            Windows.SWR.Show();
        }

        private void FSRW(object sender, RoutedEventArgs e)
        {
            Windows.FSRW.Show();
        }

        private void FC(object sender, RoutedEventArgs e)
        {
            Windows.FC.Show();
        }
        private void FIW(object sender, RoutedEventArgs e)
        {
            Windows.FIW.Show();
        }
        private void TCEH(object sender, RoutedEventArgs e)
        {
            Windows.TCEH.Show();
        }
        private void DC(object sender, RoutedEventArgs e)
        {
            Windows.DC.Show();

        }

        private void OSFD(object sender, RoutedEventArgs e)
        {
            Windows.OSFD.Show();
        }

    }
}
