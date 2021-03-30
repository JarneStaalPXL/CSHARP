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

namespace KlasseOvereveringPersoon
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

        
        private void BtnStudent_Click(object sender, RoutedEventArgs e)
        {
            List<Student> studLijst = Bestandsbewerking.LeesStudenten();

            LbxInfo.Items.Clear();

            foreach (Student item in studLijst)
            {
                LbxInfo.Items.Add(item.Gegevens);

                //OF
                LbxInfo.Items.Add($"{item.VolledigeNaam()} {item.ToString()}");

                //OF
                LbxInfo.Items.Add($"{item.AfdrukStartdatum()}");

                //OF
                LbxInfo.Items.Add($"{item.AfdrukAdres()}");

            }
        }

        private void btnPersoon_Click(object sender, RoutedEventArgs e)
        {
            Persoon prs = new Persoon();
            if (Validator.IsPresent(TxtEmail) == true && Validator.IsValidEmail(TxtEmail) == true)
            {
                prs.Email = TxtEmail.Text;
                prs.Info("");
            }
        }

        private void BtnLector_Click(object sender, RoutedEventArgs e)
        {
            List<Lector> lctLijst = Bestandsbewerking.LeesLectoren();

            LbxInfo.Items.Clear();

            foreach (Lector item in lctLijst)
            {
                LbxInfo.Items.Add(item.Gegevens);

                //OF
                LbxInfo.Items.Add($"{item.VolledigeNaam()} {item.ToString()}");

                //OF
                

                ////OF
                LbxInfo.Items.Add($"{item.AfdrukAdres()}");

            }
            //LbxInfo.Items.Add($"{lctLijst[32].AfdrukDienst()}");
        }
    }
}
