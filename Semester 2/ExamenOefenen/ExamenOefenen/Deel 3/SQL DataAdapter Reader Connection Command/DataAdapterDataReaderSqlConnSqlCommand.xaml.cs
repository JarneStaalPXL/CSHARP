using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace ExamenOefenen.Deel_3.SQL_DataAdapter_Reader_Connection_Command
{
    /// <summary>
    /// Interaction logic for DataAdapterDataReaderSqlConnSqlCommand.xaml
    /// </summary>
    public partial class DataAdapterDataReaderSqlConnSqlCommand : Window
    {
        private string conn = @"Integrated Security=SSPI;
                                Persist Security Info=False;
                                Initial Catalog=Spionshop;
                                Data Source=DESKTOP-7TSFPEJ\SQLEXPRESS";
        public DataAdapterDataReaderSqlConnSqlCommand()
        {
            InitializeComponent();
        }

        void DBAction(string name, string action)
        {
            switch (action)
            {
                case "INSERT":
                    INSERT();
                    break;
                case "DELETE":
                    DELETE();
                    break;
                case "UPDATE":
                    UPDATE();
                    break;
                default:
                    break;
            }

            void DELETE()
            {
                DataRowView rowview = (DataRowView)clientsGrid.SelectedItem;
                string selectedName = rowview.Row[1].ToString();

                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd2 = new SqlCommand())
                    {
                        cmd2.Connection = con;
                        con.Open();
                        string deleteQuery = @$" delete from Klant
                                                 where Naam = '{selectedName}'";
                        cmd2.CommandText = deleteQuery;
                        cmd2.ExecuteNonQuery();
                    }
                }
            }

            void INSERT()
            {
                using (SqlConnection con = new SqlConnection(conn))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        Random rand = new Random();
                        int randomId = rand.Next(10, 999);

                        cmd.Connection = con;
                        con.Open();
                        string insertQuery =
                            "INSERT INTO Klant(Klant_id, Naam, Voornaam)" +
                            $"VALUES('{randomId}','{name}','randomVoornaam')";
                        cmd.CommandText = insertQuery;
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            void UPDATE()
            {
                DataRowView rowview = (DataRowView)clientsGrid.SelectedItem;
                string selectedName = rowview.Row[1].ToString();

                using (SqlConnection con = new SqlConnection(conn))
                {
                    string updateQuery = @$" update Klant
                                             set Naam = '{name}'
                                             where Naam = '{selectedName}'";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(updateQuery, con);

                    // Aantal rijen tellen.
                    int res = (int)cmd.ExecuteNonQuery();
                    MessageBox.Show($"{res} row(s) affected");
                }
            }
            RetrieveData();
        }

        void RetrieveDataWithSQLAdapter()
        {
            DataTable SQLAdapterTbl = new DataTable();
            using (SqlConnection cnn = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cnn.Open();
                    cmd.Connection = cnn;
                    cmd.CommandText = "select * from Klant";

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(SQLAdapterTbl);
                }
            }

            DataView dv = new DataView(SQLAdapterTbl);

            //dv.RowFilter = "Klant_id in (3,5)";
            dv.Sort = "Klant_id";

            clientsGrid.ItemsSource = dv;
            clientsGrid.DisplayMemberPath = "Klant_id";
        }

        void RetrieveData()
        {
            dt.Rows.Clear();
            using (SqlConnection con = new SqlConnection(conn))
            {  
                con.Open();
                string Retrievequery = "select * from Klant";


                SqlCommand cmd = new SqlCommand(Retrievequery, con);

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dt.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                    }

                    DataView dv = new DataView(dt);
                    clientsGrid.ItemsSource = dv;
                    rdr.Close();
                }
                else
                {
                    MessageBox.Show("No rows");
                }
            }
        }

        void RetrieveDataWithParam()
        {
            dt.Rows.Clear();

            SqlParameter klant = new SqlParameter();
            klant.ParameterName = "@char";
            klant.Value = CharAboveBox.Text;

            string Retrievequery = "select * from Klant where Naam LIKE '%' +@char + '%'";


            using (SqlConnection con = new SqlConnection(conn))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(Retrievequery, con);

                cmd.Parameters.Add(klant);
                

                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        dt.Rows.Add(rdr[0], rdr[1], rdr[2], rdr[3]);
                    }

                    DataView dv = new DataView(dt);
                    clientsGrid.ItemsSource = dv;
                    rdr.Close();
                }
            }
        }

        DataTable dt = new DataTable();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dt.Columns.Add("Klant_id", typeof(int));
            dt.Columns.Add("Naam", typeof(string));
            dt.Columns.Add("Voornaam", typeof(string));
            dt.Columns.Add("Woonplaats", typeof(string));
            //RetrieveData();
            RetrieveDataWithSQLAdapter();
        }

        private void AddName(object sender, RoutedEventArgs e)
        {
           
            DBAction(nameBox.Text, "INSERT");
            
        }

        private void ChangeName(object sender, RoutedEventArgs e)
        {
            DBAction(changedNameBox.Text,"UPDATE");
        }

        private void DeleteUserClick(object sender, RoutedEventArgs e)
        {
            DBAction("", "DELETE");
        }

        private void CharAboveBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            RetrieveDataWithParam();
        }
    }
}
