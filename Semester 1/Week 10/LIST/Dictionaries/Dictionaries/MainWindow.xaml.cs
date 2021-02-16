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

namespace Dictionaries
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string[] namen = new string[] { "Sander", "Jarne", "Omer", "Ogun" };

            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            StringBuilder consoleTextBuilder = new StringBuilder();

            List<string> lijstVanStrings;
            Dictionary<string, double> dictionaryMetFavorieteGetallen = new Dictionary<string, double>()
            {
                {"Sander", 2.71828 },
                {"Jarne", 3.14 },
                {"Omer", 4 },
            };

            //dictionaryMetFavorieteGetallen.Add("Sander", 2); // Remove this
            //consoleTextBuilder.AppendLine(dictionaryMetFavorieteGetallen["Sander"].ToString());

            


            //foreach (string sleutel in dictionaryMetFavorieteGetallen.Keys)
            //{
            //    //consoleTextBuilder.AppendLine(dictionaryMetFavorieteGetallen[sleutel].ToString());
            //    consoleTextBuilder.AppendLine(sleutel.ToString());
            //}

            //foreach (double values in dictionaryMetFavorieteGetallen.Values)
            //{
            //    consoleTextBuilder.AppendLine(values.ToString());
            //}

            

            bool isGevonden = dictionaryMetFavorieteGetallen.TryGetValue("sander", out double value);
            if (isGevonden)
            {
                consoleTextBuilder.AppendLine(value.ToString());
            }
            else
            {
                dictionaryMetFavorieteGetallen.Add("sander", 5);
            }


            if (dictionaryMetFavorieteGetallen.ContainsKey("Jarne"))
            {
                consoleTextBuilder.AppendLine
                    ("Jarne is een geldige key");
            }


            result.Content = consoleTextBuilder.ToString();

        }
    }
}
