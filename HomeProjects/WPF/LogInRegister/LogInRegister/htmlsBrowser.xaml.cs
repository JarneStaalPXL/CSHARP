using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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

namespace LogInRegister
{
    /// <summary>
    /// Interaction logic for htmlsBrowser.xaml
    /// </summary>
    public partial class htmlsBrowser : Window
    {
        private string username;
        public htmlsBrowser(string _username)
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            username = _username;
        }
       

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            userNameLbl.Content = $"{username}";
        }

        void wb_LoadCompleted(object sender, NavigationEventArgs e)
        {
            string script = "document.body.style.overflow ='hidden'";
            WebBrowser wb = (WebBrowser)sender;
            wb.InvokeScript("execScript", new Object[] { script, "JavaScript" });
        }

        private void CV_Click(object sender, RoutedEventArgs e)
        {
            string filepath = @"C:\Users\12001144\OneDrive - PXL\PXL C#\CSHARP\HomeProjects\WPF\LogInRegister\LogInRegister\bin\Debug\FORM.html";

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.Body = filepath;
            myWebBrowser.NavigateToString(mail.Body);

            myWebBrowser.Visibility = Visibility.Visible;
            Rectangle.Visibility = Visibility.Hidden;
        }

        private void Battery_Click(object sender, RoutedEventArgs e)
        {
            string filepath = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\HomeProjects\WPF\LogInRegister\LogInRegister\bin\Debug\FORM.html";
            //myWebBrowser.NavigateToString(filepath);

            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.Body = filepath;

            myWebBrowser.NavigateToString(mail.Body);
            myWebBrowser.Visibility = Visibility.Visible;
            Rectangle.Visibility = Visibility.Hidden;
        }
    }
}
