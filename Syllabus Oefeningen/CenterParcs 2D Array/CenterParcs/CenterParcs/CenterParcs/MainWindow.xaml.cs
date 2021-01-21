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

namespace CenterParcs
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int[] aantalDagen = new int[] { 1, 2, 5, 7, 8, 12, 14, 21 };
        private string[,] woningMetPrijs = new string[5, 2]{
                                        { "2 personen", "80" },
                                        { "4 personen", "120" } ,
                                        { "4 personen lux", "140" } ,
                                        { "6 personen", "180" },
                                        { "8 personen", "200"} };
        public MainWindow()
        {
            InitializeComponent();

            for (int i = 0; i < woningMetPrijs.GetLength(0); i++)
            {
                typeWoningBox.Items.Add(woningMetPrijs[i, 0]);
            }
            for (int j = 0; j < aantalDagen.GetLength(0); j++)
            {
                aantalDagenBox.Items.Add(aantalDagen[j]);
            }
        }

        private void woningBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (typeWoningBox.SelectedIndex > -1 && aantalDagenBox.SelectedIndex > -1)
            {
                //int aantalDagen = aantalDagen[aantalDagenBox.SelectedIndex];

                int woningMetPrijS = int.Parse(woningMetPrijs[typeWoningBox.SelectedIndex, 1]);

                int aantalDageN = aantalDagen[aantalDagenBox.SelectedIndex];

                prijsOutput.Text = $"{woningMetPrijS * aantalDageN}";


                //int resultaat = aantalDagen * woningMetPrijS;

            }
        }
        private void aantalDagenBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (typeWoningBox.SelectedIndex > -1 && aantalDagenBox.SelectedIndex > -1)
            {
                //int aantalDagen = aantalDagen[aantalDagenBox.SelectedIndex];

                int woningMetPrijS = int.Parse(woningMetPrijs[typeWoningBox.SelectedIndex, 1]);

                int aantalDageN = aantalDagen[aantalDagenBox.SelectedIndex] ;

                prijsOutput.Text = $"{woningMetPrijS * aantalDageN}";

                //int resultaat = aantalDagen * woningMetPrijS;

            }
        }
    }
}
