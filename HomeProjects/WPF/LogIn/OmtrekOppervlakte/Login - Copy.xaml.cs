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
using System.Windows.Shapes;

namespace OmtrekOppervlakte
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string[] usernames = new string[20];
        private string[] password = new string[20];

        public Login()
        {
            InitializeComponent();
            // The password character is an asterisk.
            passwordBox.PasswordChar = '*';
            // The control will allow no more than 14 characters.
            passwordBox.MaxLength = 14;
        }

        

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            LoginUser();
        }

        private void LoginUser()
        {

            var bc = new BrushConverter();
            if (usernames.Contains(usernameBox.Text)  && password.Contains(passwordBox.Password))
            {
                login.Content = "LOGGED IN";

                login.Background = (Brush)bc.ConvertFrom("#17d111");
                results.Content = $"Welcome {usernameBox.Text}!";
            }
            else
            {

                login.Content = "Wrong Username Or Password";
                login.Background = (Brush)bc.ConvertFrom("#d40f0f");
                results.Content = "Please check for spelling mistakes,\n wrong username or password.";
            }
        }
    }
}
