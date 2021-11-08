using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Globalization;
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

namespace Oefening_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static string con =
        //        @"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = Spionshop;
        //        Data Source = DESKTOP-7TSFPEJ\SQLEXPRESS";
        private static string con =
                @"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = Spionshop;
                Data Source = PF2B3Y6V\SQLEXPRESS";
        private static string nameToWorkWith = "";
        private static string StrKlantId = "";
        private static int KlantId;

        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowDB();
        }

        void ShowDB()
        {
            outputBox.Items.Clear();
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = "select * from Klant";

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        outputBox.Items.Add($"{reader[1]} {reader[2]} ({reader[0]}) {reader[3]}");
                    }
                }
            }
        }

        private void BtnAddClick(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                cmd.CommandText = $"INSERT INTO Klant(Klant_id,Naam,Voornaam,Woonplaats,Geboortedatum,Gebruikersnaam,Pwd) " +
                    $"values({rand.Next(30, 100)},'{AchternaamBox.Text}','{voornaamBox.Text}','{WoonplaatsBox.Text}'," +
                    $"'{GeboortedatumBox.Text}','{GebruikersnaamBox.Text}','{WachtwoordBox.Text}')";
                int number = cmd.ExecuteNonQuery();


            }
            MessageBox.Show("Succesfully added");

            ShowDB();
            
        }

        
        private void BtnUpdateClick(object sender, RoutedEventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;

                

                cmd.CommandText = $"UPDATE Klant " +
                    $"set Naam='{AchternaamBox.Text}'," +
                    $"Voornaam='{voornaamBox.Text}'," +
                    $"Woonplaats='{WoonplaatsBox.Text}'," +
                    $"Geboortedatum='{GeboortedatumBox.Text}'," +
                    $"Gebruikersnaam='{GebruikersnaamBox.Text}'," +
                    $"Pwd='{WachtwoordBox.Text}' WHERE Voornaam='{nameToWorkWith}'";
                int number = cmd.ExecuteNonQuery();

            }
            MessageBox.Show($"{voornaamBox.Text} Succesfully updated");
            ShowDB();
            
        }


        private void BtnDeleteClick(object sender, RoutedEventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(con))
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cnn;
                cmd.CommandText = $"SELECT * from Klant WHERE Voornaam='{nameToWorkWith}'";

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader[0] != string.Empty)
                        {
                            StrKlantId = reader[0].ToString();
                            KlantId = int.Parse(StrKlantId);
                        }
                    }
                }

                cmd.CommandText = $"delete BestellingDetail where BD_id='{KlantId}'";
                cmd.CommandText = $"delete Bestelling where Klant_Id='{KlantId}'";
                cmd.CommandText = $"delete Klant WHERE Voornaam='{nameToWorkWith}'";
            }
            MessageBox.Show($"{voornaamBox.Text} Succesfully deleted");
            ShowDB();
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (outputBox.SelectedIndex > -1)
            {
                string selectedUser = outputBox.SelectedItem.ToString();
                string[] array = selectedUser.Split(' ');

                string naam = array[0];


                using (SqlConnection cnn = new SqlConnection(con))
                {
                    cnn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cnn;

                    cmd.CommandText = $"SELECT * from Klant where naam= '{naam}'";
                    int number = cmd.ExecuteNonQuery();


                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader[4] != string.Empty)
                            {
                                string[] birthDate = reader[4].ToString().Split(' ');
                                string date = DateTime.Parse(birthDate[0]).ToString("yyyy-MM-dd");
     
                                voornaamBox.Text = reader[1].ToString();
                                AchternaamBox.Text = reader[2].ToString();
                                WoonplaatsBox.Text = reader[3].ToString();
                                GeboortedatumBox.Text = date;
                                GebruikersnaamBox.Text = reader[5].ToString();
                                WachtwoordBox.Text = reader[6].ToString();
                                nameToWorkWith = reader[2].ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
