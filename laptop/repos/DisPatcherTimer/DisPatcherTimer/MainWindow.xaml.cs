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
using System.Windows.Threading;

namespace DisPatcherTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int timer = 5;
        private DispatcherTimer dispatcher;
        public MainWindow()
        {
            InitializeComponent();
            dispatcher = new DispatcherTimer();
            dispatcher.Interval = new TimeSpan(0, 0, 1);
            dispatcher.Tick += ChangeLabel_Tick;
            dispatcher.Start();
        }
        private void ChangeLabel_Tick(object sender, EventArgs e)
        {
            if (timer > 0)
            {
                timer--;
            }
            else
            {
                dispatcher.Stop();
            }
            CounterLabel.Content = timer.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer = 5;
            CounterLabel.Content = timer.ToString();
            dispatcher.Start();
        }
    }
}