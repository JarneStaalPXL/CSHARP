using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Deel_2.ClassGenericCollection
{
    /// <summary>
    /// Interaction logic for ListOfUsers.xaml
    /// </summary>
    public partial class ListOfUsers : Window
    {
        public ListOfUsers()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            lstBox.Items.Clear();
            string usern = usernameBox.Text;

            User user = new User(usern);

            user.AddToList(new User(usern));

            foreach (User usr in User.lstUsers)
            {
                Debug.WriteLine(usr.Username);
            }
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            foreach (User usr in User.lstUsers)
            {
                lstBox.Items.Add(usr.Username);
            }
        }
    }
}
