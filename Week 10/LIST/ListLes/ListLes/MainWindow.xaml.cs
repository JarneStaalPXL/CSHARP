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

namespace ListLes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            ListBoxItem listBoxItemGetal = new ListBoxItem();
            listBoxItemGetal.Content = 4;
            ListBoxItem listBoxItemNaam = new ListBoxItem();
            listBoxItemNaam.Content = "Samir";
            MijnListBox.Items.Add(listBoxItemGetal);
            MijnListBox.Items.Add(listBoxItemNaam);


            ListBoxItem l = new ListBoxItem();
            l.Content = "Samir";
            MijnListBox.Items.Add(l);
            ListBoxItem lb = new ListBoxItem();
            lb.Content = "Samir";
            MijnListBox.Items.Add(lb);
            ListBoxItem item = (ListBoxItem)MijnListBox.SelectedItem;
            if (MijnListBox.SelectedIndex != -1)
            {
                ListBoxItem itemIndex = (ListBoxItem)MijnListBox.Items[MijnListBox.SelectedIndex];
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MijnListBox.Items.Add(NaamTextBox.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MijnListBox.Items.Remove(MijnListBox.SelectedItem);
        }

    }
}
