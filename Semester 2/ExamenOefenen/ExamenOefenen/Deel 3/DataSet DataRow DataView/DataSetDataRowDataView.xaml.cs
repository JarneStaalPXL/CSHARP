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

namespace ExamenOefenen.Deel_3
{
    /// <summary>
    /// Interaction logic for DataSetDataRowDataView.xaml
    /// </summary>
    public partial class DataSetDataRowDataView : Window
    {
        public DataSetDataRowDataView()
        {
            InitializeComponent();
        }

        private static DataSet ds = new DataSet();
        private static DataTable dt = new DataTable("MEDEWERKERS");
        private static DataView dv = new DataView(dt);
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DataColumn dcId = new DataColumn("ID", typeof(int));
            DataColumn dcFirstname = new DataColumn("FIRSTNAME", typeof(string));
            DataColumn dcLastname = new DataColumn("LASTNAME", typeof(string));
            DataColumn dcJob = new DataColumn("JOB", typeof(string));
            DataColumn dcGender = new DataColumn("GENDER", typeof(string));

            dcId.Unique = true;

           

            // Unieke constraint voor naam toepassen.
            //UniqueConstraint uniek = new UniqueConstraint(dcId);


            //Adding columns for DataTable MEDEWERKERS
            dt.Columns.Add(dcId);
            dt.Columns.Add(dcFirstname);
            dt.Columns.Add(dcLastname);
            dt.Columns.Add(dcJob);
            dt.Columns.Add(dcGender);

            DataColumn[] sleutel = { dcId };
            dt.PrimaryKey = sleutel;

            //Adding rows for DataTable MEDEWERKERS
            dt.Rows.Add(1,"Peter","Noss","Coder","M");
            dt.Rows.Add(2,"Ara","Consta","Manager","M");

            //Adding rows in a different way
            DataRow rij = dt.NewRow();
            rij["ID"] = 3;
            rij["FIRSTNAME"] = "fname";
            rij["LASTNAME"] = "lname";
            rij["JOB"] = "Logistics";
            rij["GENDER"] = "M";
            dt.Rows.Add(rij);


            if (!File.Exists("yeet.csv"))
            {
                using (StreamWriter sw = new StreamWriter("yeet.csv"))
                {
                    sw.WriteLine("4,Bob;Ross;Coder;M");
                }
            }

            OpenFileDialog ofd = new OpenFileDialog();
            //ofd.ShowDialog();
            //string[] array1 = File.ReadAllText(ofd.fileName).Split(';');


            using (StreamReader sr = new StreamReader("yeet.csv"))
            {
                string[] array;
                while (!sr.EndOfStream)
                {
                    array = sr.ReadLine().Split(';'); // Bob;Ross;Coder;M
                    dt.Rows.Add(array[0], array[1], array[2], array[3], array[4]);
                }
            }

            //Adding DataTable dt to DataSet ds
            ds.Tables.Add(dt);
            datagrid.ItemsSource = dv;


            WriteToXML();
        }

        void WriteToXML()
        {
            dt.WriteXml(@"users.xml");
        }

        private void RemoveSelectedRow_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView rowview = (DataRowView)datagrid.SelectedItem;
                string FIRSTNAME = rowview.Row[0].ToString();
                string LASTNAME = rowview.Row[1].ToString();
                string JOB = rowview.Row[2].ToString();
                string GENDER = rowview.Row[3].ToString();

                MessageBox.Show($"{FIRSTNAME} {LASTNAME} {JOB} {GENDER}\nIs succesfully removed", "Information User");

                dt.Rows.RemoveAt(datagrid.SelectedIndex);
                
            }
            catch (Exception)
            {

                MessageBox.Show("Item cannot be removed as it has no contents");
            }
        }

        private void AddRow_Click(object sender, RoutedEventArgs e)
        {
            string FIRSTNAME = firstnameBox.Text;
            string LASTNAME = lastnameBox.Text;
            string JOB = jobBox.Text;
            string GENDER = genderBox.Text;

            Random rand = new Random();
            int num = rand.Next(30, 99);

            dt.Rows.Add(num,FIRSTNAME,LASTNAME,JOB,GENDER);

            firstnameBox.Text = string.Empty;
            lastnameBox.Text = string.Empty;
            jobBox.Text = string.Empty;
            genderBox.Text = string.Empty;
        }
    }
}
