using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Data.Oefening_23_DataSet_Medewerkers
{
    /// <summary>
    /// Interaction logic for DataSetMdw.xaml
    /// </summary>
    public partial class DataSetMdw : Window
    {
        public DataSetMdw()
        {
            InitializeComponent();
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable("");

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            MaakTabellen();
            VulTabellen();
        }

        private int counter;
        void MaakTabellen()
        {
            counter++;
            

            if (counter <= 1)
            {
                DataColumn dcMnr = new DataColumn("mnr", typeof(int));
                DataColumn dcNaam = new DataColumn("naam", typeof(string));
                DataColumn dcVoorn = new DataColumn("voorn", typeof(string));
                DataColumn dcFunctie = new DataColumn("functie", typeof(string));
                DataColumn dcChef = new DataColumn("chef", typeof(string));
                DataColumn dcGbdatum = new DataColumn("gbdatum", typeof(DateTime));
                DataColumn dcMaandsal = new DataColumn("maandsal", typeof(float));
                DataColumn dcComm = new DataColumn("comm", typeof(float));
                DataColumn dcAfd = new DataColumn("afd", typeof(int));



                dcChef.AllowDBNull = true;
                dcComm.AllowDBNull = true;

                dt.Columns.Add(dcMnr);
                dt.Columns.Add(dcNaam);
                dt.Columns.Add(dcVoorn);
                dt.Columns.Add(dcFunctie);
                dt.Columns.Add(dcChef);
                dt.Columns.Add(dcGbdatum);
                dt.Columns.Add(dcMaandsal);
                dt.Columns.Add(dcComm);
                dt.Columns.Add(dcAfd);


                DataColumn[] sleutel = { dcMnr };
                dt.PrimaryKey = sleutel;

                ds.Tables.Add(dt);
            }

            
        }

        void VulTabellen()
        {
            ds.Clear();
            dt.Rows.Add(new object[] { 1, "PALMAERS", "KRISTOF", "TRAINER", "7905", "1985-12-17", 2800, DBNull.Value, 20 });
            dt.Rows.Add(new object[] { 2, "DOX", "PAUL", "TRAINER", "7905", "1972-11-17", 3500, DBNull.Value, 20 });
            dt.Rows.Add(new object[] { 3, "VOS", "FRANCIS", "DEPARTEMENTSHOOFD", "7905", "1989-3-12", 5800.55, DBNull.Value, 10 });
            dt.Rows.Add(new object[] { 4, "BRIERS", "PATRICIA", "TRAINER", "7905", "1985-12-17", 2250, 3000.99, 20 });
            dt.Rows.Add(new object[] { 5, "BRUGGEN", "NATACHA", "COORDINATOR", "7905", "1985-12-17", 2250, 2950, 30 });

            DataView dv = new DataView(dt);
            outputGrid.ItemsSource = dv;
        }

        private void BtnMedTabel_Click(object sender, RoutedEventArgs e)
        {
            ds.Clear();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"C:\Users\jarne\OneDrive - PXL\PXL C#\CSHARP\Semester 2\ExamenOefenen\ExamenOefenen\Oefeningenbundel\Oefeningen Data\Oefening 23 DataSet Medewerkers";
            //ofd.ShowDialog();

            using (StreamReader sr = new StreamReader(Settings.filePath))
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
    }
}
    