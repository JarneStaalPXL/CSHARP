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

namespace Oefening_32_Listbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<string> list = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ItemVerwijderen(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Remove(listbox1.SelectedItem);
        }

        private void listboxWissen(object sender, RoutedEventArgs e)
        {
            listbox1.Items.Clear();
        }

        private void listboxSorteren(object sender, RoutedEventArgs e)
        {
            
        }

        private void vervangen(object sender, RoutedEventArgs e)
        {
            if (listbox1.SelectedIndex <= -1)
            {

            }
            else
            {
                listbox1.Items.Remove(listbox1.SelectedItem);

                string name = nameReplaceBox.Text;

                ListBoxItem item = new ListBoxItem();

                item.Content = name;

                listbox1.Items.Add(item);
            } 
        }

        private void toevoegen(object sender, RoutedEventArgs e)
        {
            string name = nameAddBox.Text;

            ListBoxItem item = new ListBoxItem();

            item.Content = name;

            listbox1.Items.Add(item);
        }

        private void zoeken(object sender, RoutedEventArgs e)
        {
            int counter = 1;
            foreach (ListBoxItem item in listbox1.Items)
            {
                if (item.Content.Equals(nameSearchBox.Text))
                {
                    itemFoundBox.Content = $"{counter}";
                }
                else
                {
                    itemFoundBox.Content = "niet gevonden";
                }
                counter++;
            }
        }

        private void listbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int num = listbox2.SelectedItems.Count;
            amountItemsSelected.Text = $"{num} geselecteerde items";
        }
    }
}
