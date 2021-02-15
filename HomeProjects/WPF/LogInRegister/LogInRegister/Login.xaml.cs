using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
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

namespace LogInRegister
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
            usernameBoxLogin.Focus();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            
        }


        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBoxLogin.Text;
            string password = PasswordBoxLogin.Password;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT * from Login where username='" + username + "' AND password='" + password + "'";
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show("Welcome " + reader[1]);
                }
                con.Close();
                login.BorderBrush = Brushes.LightGreen;
                usernameBoxLogin.Text = string.Empty;
                PasswordBoxLogin.Password = string.Empty;

                //Login Login = new Login();
                //Login.Close();

                //htmlsBrowser htmlsBrowser = new htmlsBrowser();

                htmlsBrowser htmlsBrowser = new htmlsBrowser(username);
                htmlsBrowser.Show();
                this.Close();
            }
            else
            {
                MessageBoxResult answer = MessageBox.Show("Zou u met deze gegevens een account willen maken?", "Account niet gevonden",
                    MessageBoxButton.YesNo, MessageBoxImage.Error);

                if (answer == MessageBoxResult.Yes && username != "" && password!= "")
                {
                    OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
                    OleDbCommand cmd2 = con2.CreateCommand();
                    con2.Open();
                    cmd2.CommandText = "INSERT INTO Login([username],[password])Values('" + username + "','" + password + "')";
                    cmd2.Connection = con2;
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("You have been succesfully registered! You can now log in.", "Congrats");
                    con2.Close();
                }
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBoxLogin.Text;
            string password = PasswordBoxLogin.Password;

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "SELECT * from Login where username='" + username + "' AND password='" + password + "'";
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    MessageBox.Show("You are already signed up as " + reader[1]);
                }
                con.Close();
                login.BorderBrush = Brushes.LightGreen;
            }
            else
            {
                OleDbConnection con2 = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
                OleDbCommand cmd2 = con2.CreateCommand();
                con2.Open();
                cmd2.CommandText = "INSERT INTO Login([username],[password])Values('" + username + "','" + password + "')";
                cmd2.Connection = con2;
                cmd2.ExecuteNonQuery();
                MessageBox.Show("You have been succesfully registered! You can now log in.", "Congrats");
                con2.Close();
            }
        }

        private void Replace_Username_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBoxLogin.Text;
            string password = PasswordBoxLogin.Password; 



            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = $"SELECT username from Login where username='" + username+ "' AND password='" + password + "'";
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show("Welcome " + reader[1]);
                }
                con.Close();
                MessageBoxResult answer = MessageBox.Show("Do you want to change your username?", "Username Change Request",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (answer == MessageBoxResult.Yes)
                {

                    string changeNameTo = Interaction.InputBox("Choose a new username",
                                                               "Username Change",
                                                                "",
                                                                500);
                    con.Open();
                    cmd.CommandText = $"update Login set username='" + changeNameTo + "' where username='" + username + "' AND password='" + password + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been succesfully registered! You can now log in.", "Congrats");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Aight then");
            }
        }

        private void Replace_Password_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameBoxLogin.Text;
            string password = PasswordBoxLogin.Password;



            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../Login.accdb");
            OleDbCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = $"SELECT username from Login where username='" + username + "' AND password='" + password + "'";
            cmd.Connection = con;
            OleDbDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    //MessageBox.Show("Welcome " + reader[1]);
                }
                con.Close();
                MessageBoxResult answer = MessageBox.Show("Do you want to change your password?", "Password Change Request",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (answer == MessageBoxResult.Yes)
                {

                    string changePasswordTo = Interaction.InputBox("Choose a new password",
                                                               "Password Change",
                                                                "",
                                                                500);
                    con.Open();
                    cmd.CommandText = $"update Login set password='" + changePasswordTo + "' where username='" + username + "' AND password='" + password + "'";
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("You have been succesfully registered! You can now log in.", "Congrats");
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }
    }

}
