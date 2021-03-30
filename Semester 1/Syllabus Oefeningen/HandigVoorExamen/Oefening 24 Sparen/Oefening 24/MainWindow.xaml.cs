using System;
using System.Collections.Generic;
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


namespace Oefening_24
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


        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            int tel = 0;
            float totVerhoging = 0, totWeekgeld = 0, totSpaargeld = 0;
            // Inlezen van gegevens.
            float verhoging = float.Parse(TxtVerhoging.Text);
            float weekgeld = float.Parse(TxtWeekgeld.Text);
            float eindbedrag = float.Parse(TxtSpaarbedrag.Text);
            // Aantal weken tellen met verhoging.
            while (totSpaargeld < eindbedrag)
            {
                totWeekgeld += weekgeld; // 5 10 15 20 ...
                totVerhoging += verhoging; // 0.2 0.4 0.6 ...
                totSpaargeld = totWeekgeld + totVerhoging; // 5.2 10.4 15.6 ...
                tel++;
            }
            TxtResultaat.Text = $"Spaarbedrag na {tel} weken: {totWeekgeld}\r\n\r\nExtra weekgeld op dat moment: {totVerhoging}\r\n\r\nTotaal spaargeld: { totSpaargeld}";
}
        private void BtnWissen_Click(object sender, RoutedEventArgs e)
        {
            TxtWeekgeld.Text = "10";
            TxtVerhoging.Text = "2";
            TxtSpaarbedrag.Text = "200";
            TxtResultaat.Text = "";
            TxtWeekgeld.Focus();
        }
        private void BtnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
    }
