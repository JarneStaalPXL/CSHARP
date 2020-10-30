using System;
using System.Windows;
using System.Windows.Controls;
using System.IO;
using System.Diagnostics;

namespace UserRegistrator
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

        string[] names = new string[1];
        string[] adress = new string[1];

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                string[] names = new string[1];
                string[] adress = new string[1];
                names[i] = Console.ReadLine();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                string[] names = new string[1];
                string[] adress = new string[1];
                adress[i] = Console.ReadLine();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "Database");
            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");
            System.IO.Directory.CreateDirectory(dbPath);

        }

        private void Output(object sender, RoutedEventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "Database");
            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");

            const string UNDERLINE = "\x1B[4m";
            const string RESET = "\x1B[0m";
            Console.WriteLine(UNDERLINE + "\nSubmitted Data\n" + RESET);

            string[] names = new string[1];
            string[] adress = new string[1];

            StreamWriter writer = new StreamWriter(inputFile, true);
            DateTime date1 = DateTime.Now;
            writer.WriteLine($"------------------USER INFO------------------ \n{date1.ToString(System.Globalization.CultureInfo.InvariantCulture)} \n");
            for (int j = 0; j < names.Length; j++)
            {
                writer.WriteLine($"Name: {names[j]}");
                writer.WriteLine($"Adress: {adress[j]}\n");
            }
            writer.Close();

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Name: {names[i]} \n");
                Console.WriteLine($"Adress: {adress[i]} \n");
            }
        }
    }
}
