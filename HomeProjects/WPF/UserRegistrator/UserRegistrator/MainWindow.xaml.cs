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
                names[i] = Console.ReadLine();
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            for (int i = 0; i < 1; i++)
            {
                adress[i] = Console.ReadLine();
            }
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Directory.GetCurrentDirectory(); //@"C:\Users\jarne\source\repos\Arraytest\";
            string dbPath = System.IO.Path.Combine(filePath, "Database");
            System.IO.Directory.CreateDirectory(dbPath);

            string inputFile = System.IO.Path.Combine(dbPath, "SubmittedUserInfo.txt");


            Process myProcess = new Process();
            Process.Start("notepad", @"C:\Users\12001144\OneDrive - PXL\PXL C#\HomeProjects\Console\Arraytest\Arraytest\bin\Debug\netcoreapp3.1\Database\SubmittedUserInfo.txt");
        }
    }
}
