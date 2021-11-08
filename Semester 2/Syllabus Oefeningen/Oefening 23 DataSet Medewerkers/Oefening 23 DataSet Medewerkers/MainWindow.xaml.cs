using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace Oefening_23_DataSet_Medewerkers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Medewerkers");
        string filePath = @"DatMedewerkers.csv";

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            VulTabellen();
        }

        private void BtnToevoegen(object sender, RoutedEventArgs e)
        {

            dt.Rows.Add(new object[] { 1, "PALMAERS", "KRISTOF", "TRAINER", "7905", "1985-12-17", 2800, DBNull.Value, 20 });
            dt.Rows.Add(new object[] { 2, "DOX", "PAUL", "TRAINER", "7905", "1972-11-17", 3500, DBNull.Value, 20 });
            dt.Rows.Add(new object[] { 3, "VOS", "FRANCIS", "DEPARTEMENTSHOOFD", "7905", "1989-3-12", 5800.55, DBNull.Value, 10 });
            dt.Rows.Add(new object[] { 4, "BRIERS", "PATRICIA", "TRAINER", "7905", "1985-12-17", 2250, 3000.99, 20 });
            dt.Rows.Add(new object[] { 5, "BRUGGEN", "NATACHA", "COORDINATOR", "7905", "1985-12-17", 2250, 2950, 30 });

            DataView dv = ds.Tables["Medewerkers"].DefaultView;
            DataGridMed.ItemsSource = dv;
        }

        private void BtnMedTabel(object sender, RoutedEventArgs e)
        {
            
            using (StreamReader sr = new StreamReader(filePath))
            {
                string[] array;
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(';');

                    object var8;

                    if (array[7] == "")
                    {
                        var8 = DBNull.Value;
                    }
                    else
                    {
                        var8 = int.Parse(array[7]);
                    }

                    dt.Rows.Add(new object[] { array[0], array[1], array[2], array[3], array[4], Convert.ToDateTime(array[5]), float.Parse(array[6]), var8, int.Parse(array[8]) });
                    
                }
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            ds.Clear();
        }

        void VulTabellen()
        {
            // Kolommen declareren 
            DataColumn dcMnr = new DataColumn("Mnr", typeof(int));
            DataColumn dcNaam = new DataColumn("Naam", typeof(string));
            DataColumn dcVoorn = new DataColumn("Voorn", typeof(string));
            DataColumn dcFunctie = new DataColumn("Functie", typeof(string));
            DataColumn dcChef = new DataColumn("Chef", typeof(string));
            DataColumn dcGbdatum = new DataColumn("Gbdatum", typeof(DateTime));
            DataColumn dcMaandsal = new DataColumn("Maandsal", typeof(float));
            DataColumn dcComm = new DataColumn("Comm", typeof(float));
            DataColumn dcAfd = new DataColumn("Afd", typeof(int));

            dt.Columns.Add(dcMnr);
            dt.Columns.Add(dcNaam);
            dt.Columns.Add(dcVoorn);
            dt.Columns.Add(dcFunctie);
            dt.Columns.Add(dcChef);
            dt.Columns.Add(dcGbdatum);
            dt.Columns.Add(dcMaandsal);
            dt.Columns.Add(dcComm);
            dt.Columns.Add(dcAfd);

            dcChef.AllowDBNull = true;
            dcComm.AllowDBNull = true;

            // Primaire sleutel aanduiden.
            DataColumn[] sleutel = { dcMnr }; // kunnen meerdere kolommen zijn => dus type array 
            dt.PrimaryKey = sleutel;

            ds.Tables.Add(dt);
        }
    }
}
