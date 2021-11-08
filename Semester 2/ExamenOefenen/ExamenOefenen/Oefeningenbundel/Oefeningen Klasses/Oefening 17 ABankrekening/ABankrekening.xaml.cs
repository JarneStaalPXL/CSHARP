using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_17_ABankrekening
{
    /// <summary>
    /// Interaction logic for ABankrekening.xaml
    /// </summary>
    public partial class ABankrekening : Window
    {
        private Bankrekening zRek;
        private Bankrekening sRek;
        public ABankrekening()
        {
            InitializeComponent();
            zRek = new Zichtrekening(2000, "PXL Digital | Campus PXL Hasselt", "Elfde­Liniestraat 26, 3500 Hasselt");
            UpdateZichtRekening();



            sRek = new Spaarrekening(9500, "PXL Digital | Campus PXL Hasselt", "Elfde­Liniestraat 26, 3500 Hasselt");
            UpdateSpaarRekening();
        }

        private void BtnSaldo_Click(object sender, RoutedEventArgs e)
        {
            zRek.CreditSaldo(float.Parse(inputtedValue.Text));
            sRek.DebetSaldo(float.Parse(inputtedValue.Text));

            UpdateZichtRekening();
            UpdateSpaarRekening();
            
        }

        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        void UpdateZichtRekening()
        {
            nameBoxZicht.Content = zRek.Naam + ", " + zRek.Adres;
            saldoZichtrekeningLbl.Content = $"Huidig saldo:   {zRek.HuidigSaldo:c}";
            renteZichtrekeningLbl.Content = $"Rente:             {zRek.BerekenRente():c}";
        }

        void UpdateSpaarRekening()
        {
            nameBoxSpaar.Content = sRek.Naam + ", " + sRek.Adres;
            saldoSpaarrekeningLbl.Content = $"Hudig saldo:   {sRek.HuidigSaldo:c}";
            renteSpaarrekeningLbl.Content = $"Rente:            {sRek.BerekenRente():c}";
        }
    }
}
