using System;
using System.IO;
using System.Windows;

namespace VoorbeeldBestanden
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

        private void BtnStreamWiterReader_Click(object sender, RoutedEventArgs e)
        {
            string pad = @"..\..\Bestanden\Tekstbestand.txt";
            StreamWriter sw = new StreamWriter(pad);

            sw.WriteLine("Volgorde van getallen :");
            for (int i = 0; i < 10; i++)
            {
                sw.Write($"{i * 1000} \n");
            }

            sw.WriteLine();

            sw.Write("Einde");
            sw.Close();




            // LEZEN
            //FileStream fsRead = new FileStream(pad, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(pad);


            //while (!sr.EndOfStream)
            //{
            //    TxtResultaat.AppendText(sr.ReadLine());
            //}

            TxtResultaat.Text = sr.ReadToEnd();

            //Objecten sluiten
            sr.Close();

        }

        private void BtnFileStream_Click(object sender, RoutedEventArgs e)
        {
            string pad = @"..\..\Bestanden\Klas.txt";
            TxtResultaat.Clear();

            TxtResultaat.Text = File.ReadAllText(pad);

            //using (FileStream fs = new FileStream(pad, FileMode.Open, FileAccess.Read))
            //{
            //    using (StreamReader sr = new StreamReader(fs))
            //    {
            //        TxtResultaat.Text = sr.ReadToEnd();
            //    }
            //}
        }

        private void BtnFileStreamWriter_Click(object sender, RoutedEventArgs e)
        {
            string schrijfpad = @"..\..\Bestanden\klasWrite.txt";
            string leespad = @"..\..\Bestanden\klas.txt";

            using (FileStream fs = new FileStream(schrijfpad, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    using (StreamReader sr = new StreamReader(leespad))
                    {
                        string naam = string.Empty;
                        while (!sr.EndOfStream)
                        {
                            naam = sr.ReadLine();
                            sw.WriteLine(naam);
                            LbxNamen.Items.Add(naam);
                        }
                    }
                }
            }
        }
                
       

        private void BtnKlasseFile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWriteAllText_Click(object sender, RoutedEventArgs e)
        {
            string pad = @"..\..\Bestanden\NamenFile.txt";

            if (!File.Exists(pad))
            {
                string lijn = "Opleidingsonderdeel= C# Advanced\n";
                File.WriteAllText(pad, lijn);

                File.AppendAllText(pad, "Klas: 1PRO A+B - Dagopleiding \n");
                File.AppendAllText(pad, "Klas: 1PRO C+D - Dagopleiding \n");
                File.AppendAllText(pad, "Klas: 1PRO E+F - Dagopleiding \n");
                File.AppendAllText(pad, "Klas: 1PRO G+H - Dagopleiding \n");
                File.AppendAllText(pad, "Klas: 1PRO I+J - Dagopleiding \n");
                File.AppendAllText(pad, "\n");
                File.AppendAllText(pad, "Klas: 1PRO I+J - Avondopleiding\n");
            }

            TxtResultaat.Clear();
            TxtResultaat.Text = File.ReadAllText(pad);
        }

        private void BtnWriteCsv_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnFixRead_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
