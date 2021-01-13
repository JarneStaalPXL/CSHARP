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

namespace Testing2DArrays
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        string[,] array2D = new string[10, 10];

        public MainWindow()
        {
            InitializeComponent();

            inputPassword.PasswordChar = '*';
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {






        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            

            string inputName = input.Text;
            string password = inputPassword.Password;


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    array2D[i, 0] = inputName;
                    array2D[i, 1] = password;
                    //label.Content += " " + (array2D[i, j]);
                }

            }
            //label.Content += "\n";


            MessageBox.Show("User Added");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                if (array2D[i, 0] == input.Text && array2D[i, 1] == inputPassword.Password)
                {
                    label.Content = "Succesfully logged in";
                }
                else
                {
                    label.Content = "Wrong username/password or not registered";
                }
            }
        }
    }
}