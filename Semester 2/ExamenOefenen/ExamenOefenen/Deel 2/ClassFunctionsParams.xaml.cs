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

namespace ExamenOefenen.Deel_2
{
    /// <summary>
    /// Interaction logic for ClassFunctionsParams.xaml
    /// </summary>
    public partial class ClassFunctionsParams : Window
    {
        public ClassFunctionsParams()
        {
            InitializeComponent();
        }

        private List<Gebruiker> userList = new List<Gebruiker>();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Gebruiker gb = new Gebruiker(voornaamBox.Text, achternaamBox.Text);
            lstbox.Items.Add($"{gb.Voornaam} {gb.Naam}");
                
            //Need to add to userList to be able to save all the users
            userList.Add(gb);

            //Looping through every Gebruiker object in userList
            usersCreated.Content = "";
            foreach (Gebruiker user in userList)
            {
                usersCreated.Content += $"{user.Voornaam} {user.Naam}\n";
            }

            MessageBox.Show(gb.ToonNaam(), "ToonNaam functie gebruikt om - in te voegen");
        }
    }
}
