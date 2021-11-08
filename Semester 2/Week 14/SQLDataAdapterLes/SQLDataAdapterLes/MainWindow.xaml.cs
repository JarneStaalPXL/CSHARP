using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

namespace SQLDataAdapterLes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string cs = @"Integrated Security = SSPI; Persist Security Info = False; Initial Catalog = Spionshop; Data Source = DESKTOP-7TSFPEJ\SQLEXPRESS";
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void GetClientInformation(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(cs))
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter("spGetClientById", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@Klant_id", TextBox1.Text);
                    da.Fill(ds);

                    DataView dv = ds.Tables[0].DefaultView;
                    outputGrid.ItemsSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
