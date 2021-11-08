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

namespace ExamenOefenen.Deel_2
{
    /// <summary>
    /// Interaction logic for WindowLoadClosedClosing.xaml
    /// </summary>
    public partial class WindowLoadClosedClosing : Window
    {
        public int a;
        public WindowLoadClosedClosing()
        {
            InitializeComponent();
            a = 122;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //On load shows MessageBox
            MessageBox.Show($"The int is {a} ","Window is now loaded");
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            //Closes Window and shows MessageBox
            MessageBox.Show($"The int is {a} ", "Window is now closed");
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //Leaves everything open till you click OK on MessageBox
            MessageBox.Show($"The int is {a} ", "Window is now closing");
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Won't execute any closing or closed code -> It will determinate the process instantly
            Environment.Exit(0);
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            //The same as closing the X on the window itself
            Close();
        }
    }
}
