using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

namespace ToDoListProgram
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private List<string> courses = new List<string>() 
        { "C# Mobile", "C# Web 1", "Data Advanced", "Project Management", "WPL 3", "Extra" };
        private string chosenCourse = @"";
        private string CSharpMobile = @"CSharpMobile.txt";
        private string CSharpWeb1 = @"CSharpWeb1.txt";
        private string DataAdvanced = @"DataAdvanced.txt";
        private string ProjectManagement = @"ProjectManagement.txt";
        private string Werkplekleren3 = @"Werkplekleren3.txt";
        private string Extra = @"Extra.txt";

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1) 
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            else
            {
                CheckIfFileExists(CSharpMobile);
                CheckIfFileExists(CSharpWeb1);
                CheckIfFileExists(DataAdvanced);
                CheckIfFileExists(ProjectManagement);
                CheckIfFileExists(Werkplekleren3);
                CheckIfFileExists(Extra);

                foreach (string item in courses)
                {
                    coursesBox.Items.Add(item);
                }

                coursesBox.SelectedIndex = 0;
            }
            
        }

        void CheckIfFileExists(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write("");
                }
            }
        }

        private void Add_Item_Click(object sender, RoutedEventArgs e)
        {
            if (itemInput.Text == string.Empty)
            {
                MessageBox.Show("Please fill something in the textbox");
            }
            else
            {
                todoBox.Items.Add("- " + itemInput.Text);
                itemInput.Text = string.Empty;
                using (StreamWriter sw = new StreamWriter(chosenCourse))
                {
                    foreach (var item in todoBox.Items)
                        sw.WriteLine(item);
                }
            }
        }

        private void Remove_Item_Click(object sender, RoutedEventArgs e)
        {
            todoBox.Items.Remove(todoBox.SelectedItem);

            itemInput.Text = string.Empty;

            using (StreamWriter sw = new StreamWriter(chosenCourse))
            {
                foreach (var item in todoBox.Items)
                    sw.WriteLine(item);
            }
        }
        
        private void coursesBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            todoBox.Items.Clear();

            if (coursesBox.SelectedIndex >= 0)
            {
                switch (coursesBox.SelectedIndex)
                {
                    case 0:
                        chosenCourse = CSharpMobile;
                        break;
                    case 1:
                        chosenCourse = CSharpWeb1;
                        break;
                    case 2:
                        chosenCourse = DataAdvanced;
                        break;
                    case 3:
                        chosenCourse = ProjectManagement;
                        break;
                    case 4:
                        chosenCourse = Werkplekleren3;
                        break;
                    case 5:
                        chosenCourse = Extra;
                        break;
                    default:
                        break;
                }

                using (StreamReader sr = new StreamReader(chosenCourse))
                {
                    string[] array;
                    while (!sr.EndOfStream)
                    {
                        array = sr.ReadLine().Split('\n');
                        todoBox.Items.Add(array[0]);
                    }
                }
            }
        }
    }
}
