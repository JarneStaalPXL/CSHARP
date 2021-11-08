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

namespace ExamenOefenen.Deel_2.Inheritance
{
    /// <summary>
    /// Interaction logic for InheritanceBetweenClasses.xaml
    /// </summary>
    public partial class InheritanceBetweenClasses : Window
    {
        private string voornaam;
        private string achternaam;
        private string functie;
       
       
        public InheritanceBetweenClasses()
        {
            InitializeComponent();
        }

        private void PersoonMaken_Click(object sender, RoutedEventArgs e)
        {
            GetInput();
            Persoon ps = new Persoon();
            ps.Voornaam = voornaam;
            ps.Naam = achternaam;

            MessageBox.Show(ps.VolledigeNaam(), "Volledige naam", MessageBoxButton.OK);
            lstBox.Items.Add(ps.VolledigeNaam() + functie);

            //base works
            MessageBox.Show(ps.Gegevens);
            MessageBox.Show(ps.Lol);
        }

        private void WerknemerMaken_Click(object sender, RoutedEventArgs e)
        {
            GetInput();
            Werknemer wn = new Werknemer();
            wn.Voornaam = voornaam;
            wn.Naam = achternaam;
            wn.Functie = functie;

            MessageBox.Show(wn.Gegevens, "Volledige naam", MessageBoxButton.OK);
            lstBox.Items.Add(wn.VolledigeNaam() +" || " +wn.Functie);

        }

        public void GetInput()
        {
            voornaam = voornaamBox.Text;
            achternaam = achternaamBox.Text;
            functie = functieBox.Text;
        }

        private void BtnConvert_Click(object sender, RoutedEventArgs e)
        {
            Persoon persoon = new Persoon(); //person
            Werknemer werknemer = new Werknemer(); //worker

            persoon.Naam = "JarnePersoon"; //person.Name = "JarnePerson";
            werknemer.Naam = "JarneWerknemer";//worker.Name = "JarneWorker";

            MessageBox.Show($"{persoon.Naam}", "Naam van klasse persoon"); //Output JarnePerson
            persoon = werknemer; //person = (Persone)worker
            MessageBox.Show($"{persoon.Naam}", "Naam van klasse werknemer"); //Output JarneWorker
        }
    }
}
