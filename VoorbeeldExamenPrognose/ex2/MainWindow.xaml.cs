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

namespace ex2
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



        private string[] namen = new string[]

        { "Sander", "Quirino", "Thomas", "Cédric",
        "Jason", "Domenico", "Rickert", "Klaas", "Tom", "Stephan", "Alexander", "Yannick",
        "Robin", "Dave", "Lynn", "Arno", "Niels", "Maxiem", "Matthijs", "Kobe", "Michaël",
        "Bram", "Achraf", "Raf", "Sven", "Gerben", "Kevin", "Cem", "Steff", "Steven", "Rani",
        "Djordy", "Nick", "Mikail", "Konstantin", "Asad", "Viktor", "Antonio", "Senne",
        "Benjamin", "Stef", "Abdul", "Christiaan", "Abdurrahman", "Jurgen", "Kevin", "Silvio",
        "Nathan", "Stijn", "Bart", "Frank", "Steven", "Matty", "Arend", "Simon", "Ziggy",
        "Pascal", "Michaël", "Danny", "Robby", "Johan", "Vincent", "Wim", "Tuba", "Kristof",
        "Kenneth"
    };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
