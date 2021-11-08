using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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

namespace ExamenOefenen.Oefeningenbundel.Oefeningen_Klasses.Oefening_11_KlasseHuis
{
    /// <summary>
    /// Interaction logic for KlasseHuis.xaml
    /// </summary>
    public partial class KlasseHuis : Window
    {
        public KlasseHuis()
        {
            InitializeComponent();
        }

        private Huis huis1 = new Huis();
        private Huis huis2 = new Huis();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }


        #region Unlock Content
        public void UnlockHouse1Options()
        {
            BtnVerhogen1.IsEnabled = true;
            BtnMeerdereVerhogingen1.IsEnabled = true;
            BtnVerlagen1.IsEnabled = true;
            BtnTonen1.IsEnabled = true;
        }

        public void UnlockHouse2Options()
        {
            BtnVerhogen2.IsEnabled = true;
            BtnMeerdereVerhogingen2.IsEnabled = true;
            BtnVerlagen2.IsEnabled = true;
            BtnTonen2.IsEnabled = true;
        }
        #endregion


        #region House 1
        private void BtnCreatie1_Click(object sender, RoutedEventArgs e)
        {
            huis1.Locatie = TxtLocatie.Text;
            huis1.Lengte = double.Parse(TxtLengte.Text);
            huis1.Breedte = double.Parse(TxtBreedte.Text);
            huis1.AantalVerdieping = int.Parse(TxtAantalVerdiepingen.Text);

            if (radOpen.IsChecked == true)
                huis1.Type = "O";
            else if (radHalfopen.IsChecked == true)
                huis1.Type = "H";
            else
                huis1.Type = "G";

            UnlockHouse1Options();

            Debug.WriteLine((JsonConvert.SerializeObject(huis1, Formatting.Indented)));
        }

        private void BtnVerhogen1_Click(object sender, RoutedEventArgs e)
        {
            huis1.VerhoogAantalVerdiepingen();
        }

        private void BtnMeerdereVerhogingen1_Click(object sender, RoutedEventArgs e)
        {
            huis1.VerhoogVerdiepingenParam(int.Parse(TxtAantalVerdiepingen.Text));
        }

        private void BtnVerlagen1_Click(object sender, RoutedEventArgs e)
        {
            huis1.VerlaagAantalVerdiepingen();
        }

        private void ToonGegevens1_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = $"Gegevens van Huis 1\r\n\r\n{huis1.Locatie}\r\n{huis1.Type}\r\n" +
            $"Lengte: {huis1.Lengte}\r\n" + $"Breedte: {huis1.Breedte}\r\n" +
            $"Aantal verdiepingen: {huis1.AantalVerdieping}\r\n" +
            $"Grondoppervlakte: {huis1.Oppervlakte():n}m2\r\n" +
            $"Inhoud: {huis1.Inhoud():n}m3";
        }
        #endregion


        #region House 2
        private void BtnCreatie2_Click(object sender, RoutedEventArgs e)
        {
            huis2.Locatie = TxtLocatie.Text;
            huis2.Lengte = double.Parse(TxtLengte.Text);
            huis2.Breedte = double.Parse(TxtBreedte.Text);
            huis2.AantalVerdieping = int.Parse(TxtAantalVerdiepingen.Text);

            if (radOpen.IsChecked == true)
                huis2.Type = "O";
            else if (radHalfopen.IsChecked == true)
                huis2.Type = "H";
            else
                huis2.Type = "G";

            UnlockHouse2Options();
        }

        private void BtnVerhogen2_Click(object sender, RoutedEventArgs e)
        {
            huis2.VerhoogAantalVerdiepingen();
        }

        private void BtnMeerdereVerhogingen2_Click(object sender, RoutedEventArgs e)
        {
            huis2.VerhoogVerdiepingenParam(int.Parse(TxtAantalVerdiepingen.Text));
        }

        private void BtnVerlagen2_Click(object sender, RoutedEventArgs e)
        {
            huis2.VerlaagAantalVerdiepingen();
        }

        private void ToonGegevens2_Click(object sender, RoutedEventArgs e)
        {
            TxtResultaat.Text = $"Gegevens van Huis 2\r\n\r\n{huis2.Locatie}\r\n{huis2.Type}\r\n" +
            $"Lengte: {huis2.Lengte}\r\n" + $"Breedte: {huis2.Breedte}\r\n" +
            $"Aantal verdiepingen: {huis2.AantalVerdieping}\r\n" +
            $"Grondoppervlakte: {huis2.Oppervlakte():n}m2\r\n" +
            $"Inhoud: {huis2.Inhoud():n}m3";
        }
        #endregion

        private void LeegmakenTekstvakken_Click(object sender, RoutedEventArgs e)
        {
            TxtLocatie.Text = string.Empty;
            TxtLengte.Text = string.Empty;
            TxtBreedte.Text = string.Empty;
            TxtAantalVerdiepingen.Text = string.Empty;
            TxtResultaat.Text = string.Empty;

            radOpen.IsChecked = true;
        }
    }
}
