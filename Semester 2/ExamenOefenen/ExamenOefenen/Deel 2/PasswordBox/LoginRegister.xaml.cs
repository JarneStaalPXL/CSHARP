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

namespace ExamenOefenen.Deel_2.PasswordBox
{
    /// <summary>
    /// Interaction logic for LoginRegister.xaml
    /// </summary>
    public partial class LoginRegister : Window
    {
        public LoginRegister()
        {
            InitializeComponent();
        }

        private Dictionary<string, int> users = new Dictionary<string, int>()
        {
            {"Jarne",1234}  
        };
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            bool pswCorrect = false;
            foreach (var item in users)
            {
                if (item.Key == usernameBox.Text && item.Value == int.Parse(passwordBox.Password))
                {
                    pswCorrect = true;
                }
            }

            if (pswCorrect == true)
            {
                MessageBox.Show("Ingelogd");
                usernameBox.Text = string.Empty;
                passwordBox.Password = string.Empty;
            }
        }
    }
}
