using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Voorbeeldexamen
{
    /// <summary>
    /// Interaction logic for DataOverzicht.xaml
    /// </summary>
    public partial class DataOverzicht : Window
    {
        private DataView dvStud;
        private DataView dvVak;
        private readonly Student st = new Student();

        public DataOverzicht()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Data STUDENTEN tonen in datagrid             
            dvStud = Databank.DsStudent.Tables["student"].DefaultView;
            dgdStudenten.ItemsSource = dvStud;
            dvVak = Databank.DsStudent.Tables["Vak"].DefaultView;
            dgdVakken.ItemsSource = dvVak;
        }

        private void btnPro_Click(object sender, RoutedEventArgs e)
        {
            //// === Nieuwe DATA VIEW ===
            DataView dv3 = dvStud;
            dv3.Sort = "Naam desc";
            dv3.RowFilter = "VakCode = 'PRO'";
            // === Afdruk inDataGrid
            dgdStudenten.ItemsSource = dv3;
            //== AFDRUK TxtResultaat
            DataRow[] res = Databank.DsStudent.Tables["student"].Select("VakCode = ' PRO'");
            txtResultaat.Clear();
            foreach (DataRow kolom in res)
            {
                txtResultaat.Text += $"{kolom[1],-15} - {kolom[2]}\r\n";
            }
        }

        private void btnNaam_Click(object sender, RoutedEventArgs e)
        {
            // === Nieuwe DATA VIEW ===
            DataView dv3 = dvStud;
            dv3.RowFilter = "Naam like 'P%'";
            dv3.Sort = "naam";

            // === Afdruk inDataGrid
            dgdStudenten.ItemsSource = dv3;

            //== AFDRUK TxtResultaat
            DataRow[] res = Databank.DsStudent.Tables["student"].Select("Naam like ' P%'");
            txtResultaat.Clear();
            foreach (DataRow kolom in res)
            {
                txtResultaat.Text += $"{kolom[1],-15} - {kolom[2]}\r\n";
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            // === Afdruk in DataGrid
            dgdStudenten.ItemsSource = dvStud;
            dvStud.RowFilter = null;
            dvStud.Sort = "Naam";
            txtResultaat.Clear();
        }


    }
}
