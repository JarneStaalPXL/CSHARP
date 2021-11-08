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

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Data.Oefening_24_DataSet_Auto
{
    /// <summary>
    /// Interaction logic for AutoDS.xaml
    /// </summary>
    public partial class AutoDS : Window
    {
        public AutoDS()
        {
            InitializeComponent();
        }

        private DataSet dsAuto;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dsAuto = new DataSet("Verkoop");
            DataTable dtVrkpr = dsAuto.Tables.Add("Verkoper");
            dtVrkpr.Columns.Add("VerkoperId", typeof(int));
            dtVrkpr.Columns.Add("Naam", typeof(string));
            dtVrkpr.Columns.Add("Straat", typeof(string));
            dtVrkpr.Columns.Add("Nr", typeof(string));
            dtVrkpr.Columns.Add("Postcode", typeof(string));
            dtVrkpr.Columns.Add("Woonplaats", typeof(string));
            dtVrkpr.Columns.Add("Land", typeof(string));
            dtVrkpr.Columns.Add("Afd", typeof(string));
            dtVrkpr.PrimaryKey = new DataColumn[] { dtVrkpr.Columns["VerkoperId"] };

            DataTable dtArt = dsAuto.Tables.Add("Artikel");
            dtArt.Columns.Add("ArtId", typeof(int));
            dtArt.Columns.Add("VerkoperId", typeof(int));
            dtArt.Columns.Add("Code", typeof(string));
            dtArt.Columns.Add("Beschrijving", typeof(string));
            dtArt.Columns.Add("Aankoopprijs", typeof(decimal));
            dtArt.Columns.Add("Verkoopprijs", typeof(decimal));
            dtArt.PrimaryKey = new DataColumn[] { dtArt.Columns["ArtId"] };

            // Relatie tussen tabellen leggen.
            DataRelation VerkoperArtikel_FK = dsAuto.Relations.Add("VerkoperArtikel", dtVrkpr.Columns["VerkoperId"], dtArt.Columns["VerkoperId"]);
            dsAuto.EnforceConstraints = false; // Alle constraints uitschakelen om toe te voegen

            // GEGEVENS TOEVOEGEN VOOR VERKOPER.
            DataRow drVerkoper = dtVrkpr.NewRow();
            drVerkoper["VerkoperId"] = 10;
            drVerkoper["Naam"] = "Elon Musk";
            drVerkoper["Straat"] = "Herkenrodesingel";
            drVerkoper["Nr"] = "77";
            drVerkoper["Postcode"] = "3500";
            drVerkoper["Woonplaats"] = "Hasselt";
            drVerkoper["Land"] = "België";
            drVerkoper["Afd"] = "West-Europa";
            dtVrkpr.Rows.Add(drVerkoper);
            drVerkoper = dtVrkpr.NewRow();
            drVerkoper["VerkoperId"] = 20;
            drVerkoper["Naam"] = "Clotilde Delbos";
            drVerkoper["Straat"] = "Gouverneur Roppesingel";
            drVerkoper["Nr"] = "2";
            drVerkoper["Postcode"] = "3500";
            drVerkoper["Woonplaats"] = "Hasselt";
            drVerkoper["Land"] = "België";
            drVerkoper["Afd"] = "Azië";
            dtVrkpr.Rows.Add(drVerkoper);

            // GEGEVENS TOEVOEGEN AAN ARTIKEL.
            DataRow drArtikel = dtArt.NewRow();
            drArtikel["ArtId"] = 1;
            drArtikel["VerkoperId"] = 10;
            drArtikel["code"] = "Tesla";
            drArtikel["beschrijving"] = "Tesla Model S";
            drArtikel["aankoopprijs"] = 65000.0;
            drArtikel["verkoopprijs"] = 75500.0;
            dtArt.Rows.Add(drArtikel);
            drArtikel = dtArt.NewRow();
            drArtikel["ArtId"] = 2;
            drArtikel["VerkoperId"] = 10;
            drArtikel["code"] = "Tesla";
            drArtikel["beschrijving"] = "Tesla Model S 85kWh (Dual Motor)";
            drArtikel["aankoopprijs"] = 88400.0;
            drArtikel["verkoopprijs"] = 96250.0;
            dtArt.Rows.Add(drArtikel);
            drArtikel = dtArt.NewRow();
            drArtikel["ArtId"] = 3;
            drArtikel["VerkoperId"] = 20;
            drArtikel["code"] = "Renault";
            drArtikel["beschrijving"] = "Renault Kadjar";
            drArtikel["aankoopprijs"] = 14000;
            drArtikel["verkoopprijs"] = 18650.0;
            dtArt.Rows.Add(drArtikel);
            dsAuto.EnforceConstraints = true; // Alle constraints inschakelen

            // Afdruk in DataGrid verkoper
            DataView dv1 = dsAuto.Tables["verkoper"].DefaultView;
            dgdVerkoper.ItemsSource = dv1;

            // Afdruk in DataGrid artikel
            dgdArtikel.ItemsSource = dsAuto.Tables["artikel"].DefaultView;
        }

        private void BtnListing_Click(object sender, RoutedEventArgs e)
        {
            DataTableReader dtr = dsAuto.CreateDataReader();
            LstArtikel.Items.Add("LIJST VAN VERKOPERS");
            while (dtr.Read())
            {
                LstArtikel.Items.Add(dtr["naam"]);
            }
            // Naar volgende tabel.
            dtr.NextResult();
            LstArtikel.Items.Add("");
            LstArtikel.Items.Add("LIJST VAN AUTO'S");
            while (dtr.Read())
            {
                LstArtikel.Items.Add(dtr["beschrijving"]);
            }
        }
        private void RadAuto_Checked(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Clear();
            DataRow[] res;
            if (sender.Equals(RadTesla))
            {
                res = dsAuto.Tables["artikel"].Select("code = 'Tesla'");
            }
            else
            {
                res = dsAuto.Tables["artikel"].Select("code = 'Renault'");
            }
            foreach (DataRow rij in res)
            {
                TxtResultaat.Text += $"{rij[2],-10} {rij[3],-35}VP: {rij[5]:c}\r\n";
            }
        }
        private void dgdVerkoper_AutoGeneratingColumn(object sender, System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs e)
        {
        }
    }
}
