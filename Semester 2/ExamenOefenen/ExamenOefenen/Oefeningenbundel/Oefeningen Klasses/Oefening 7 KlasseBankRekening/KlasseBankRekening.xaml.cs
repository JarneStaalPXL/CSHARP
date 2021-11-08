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

namespace ExamenOefenen.Oefeningenbundel.Oefening_7_KlasseBankRekening
{
    /// <summary>
    /// Interaction logic for KlasseBankRekening.xaml
    /// </summary>
    public partial class KlasseBankRekening : Window
    {
        public KlasseBankRekening()
        {
            InitializeComponent();
            Bankrekening.HuidigSaldo = 500f;
            currentBalance.Text = $"{Bankrekening.HuidigSaldo}";
        }

        private void Bereken_Click(object sender, RoutedEventArgs e)
        {
            Bankrekening rekening = new Bankrekening();

            float inputAmount = float.Parse(inputNumber.Text);

            rekening.BankRekening(inputAmount);
            currentBalance.Text = $"{Bankrekening.HuidigSaldo}";
        }
    }
}
