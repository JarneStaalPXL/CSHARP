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

namespace Oefening_4_en_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int i = 1;
        private DispatcherTimer timerButton;
        private DateTime vorigeTijd;
        public MainWindow()
        {
            
            InitializeComponent();

            
            timerButton = new DispatcherTimer();
            timerButton.Interval = new TimeSpan(0, 0, 1);
            timerButton.Start();
            vorigeTijd = DateTime.Now;

            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 0, 1), DispatcherPriority.Normal, delegate
            { 
                i +=1;
                this.Lblsecond.Content = i;

            },
            this.Dispatcher);

        }

        private int a = 1;
         
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TimeSpan verschilTijd = DateTime.Now.Subtract(vorigeTijd);
            this.yeet.Content = verschilTijd.Seconds;
            //DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 0, 0, 1), DispatcherPriority.Normal, delegate
            //{
            //    a++;s
            //    this.yeet.Content = a;

            //},
            //this.Dispatcher);
        }
    }
}
