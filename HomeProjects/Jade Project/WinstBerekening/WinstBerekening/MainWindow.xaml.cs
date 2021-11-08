using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
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

namespace WinstBerekening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string answer = "";
        private readonly string profit = "Winst";
        private readonly string loss = "Verlies";
        private double somkost = 0;
        private double sominkomen = 0;
        private double availableProfitToMakeInEuro = 0;
        private double procentOf7000 = 0;
        private double laatsteMaandwinst = 0;
        private double dezeMaandwinst = 0;
        private double resetBedrag = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            #region Pulling Total Profit From File And Setting Reset Value 
            string filePath5 = Directory.GetCurrentDirectory();
            string dbPath5 = System.IO.Path.Combine(filePath5, $"DATA");
            string inputFile5 = System.IO.Path.Combine(dbPath5, "LaatsteMaandWinst.txt");
            System.IO.Directory.CreateDirectory(dbPath5);

            if (File.Exists(inputFile5))
            {
                string text = File.ReadAllText(inputFile5);
                laatsteMaandwinst = double.Parse(text);
                resetBedrag = laatsteMaandwinst;
            }
            else
            {
                StreamWriter writer69 = new StreamWriter(inputFile5, false);
                writer69.WriteLine("0");
                writer69.Close();
            }

            #endregion

            van7000winstLbl.Content = $"€ {laatsteMaandwinst} van € 7000 verdient";
            bedragInkomen1box.Focus();
        }

        private void Bereken_Som_Click(object sender, RoutedEventArgs e)
        {
            #region Receiving Data

            double.TryParse(bedragInkomen1box.Text, out double bedrag1Inkomen);
            double.TryParse(bedragInkomen2box.Text, out double bedrag2Inkomen);
            double.TryParse(bedragInkomen3box.Text, out double bedrag3Inkomen);
            double.TryParse(bedragInkomen4box.Text, out double bedrag4Inkomen);
            double.TryParse(bedragInkomen5box.Text, out double bedrag5Inkomen);
            double.TryParse(bedragInkomen6box.Text, out double bedrag6Inkomen);
            double.TryParse(bedragInkomen7box.Text, out double bedrag7Inkomen);
            double.TryParse(bedragInkomen8box.Text, out double bedrag8Inkomen);
            double.TryParse(bedragInkomen9box.Text, out double bedrag9Inkomen);
            double.TryParse(bedragInkomen10box.Text, out double bedrag10Inkomen);
            double.TryParse(bedragInkomen11box.Text, out double bedrag11Inkomen);
            double.TryParse(bedragInkomen12box.Text, out double bedrag12Inkomen);
            double.TryParse(bedragInkomen13box.Text, out double bedrag13Inkomen);
            double.TryParse(bedragInkomen14box.Text, out double bedrag14Inkomen);
            double.TryParse(bedragInkomen15box.Text, out double bedrag15Inkomen);
            double.TryParse(bedragInkomen16box.Text, out double bedrag16Inkomen);
            double.TryParse(bedragInkomen17box.Text, out double bedrag17Inkomen);
            double.TryParse(bedragInkomen18box.Text, out double bedrag18Inkomen);
            double.TryParse(bedragInkomen19box.Text, out double bedrag19Inkomen);
            double.TryParse(bedragInkomen20box.Text, out double bedrag20Inkomen);
            double.TryParse(bedragInkomen21box.Text, out double bedrag21Inkomen);
            double.TryParse(bedragInkomen22box.Text, out double bedrag22Inkomen);
            double.TryParse(bedragInkomen23box.Text, out double bedrag23Inkomen);
            double.TryParse(bedragInkomen24box.Text, out double bedrag24Inkomen);
            double.TryParse(bedragInkomen25box.Text, out double bedrag25Inkomen);
            double.TryParse(bedragInkomen26box.Text, out double bedrag26Inkomen);
            double.TryParse(bedragInkomen27box.Text, out double bedrag27Inkomen);
            double.TryParse(bedragInkomen28box.Text, out double bedrag28Inkomen);
            double.TryParse(bedragKost1box.Text, out double bedrag1kost);
            double.TryParse(bedragKost2box.Text, out double bedrag2kost);
            double.TryParse(bedragKost3box.Text, out double bedrag3kost);
            double.TryParse(bedragKost4box.Text, out double bedrag4kost);
            double.TryParse(bedragKost5box.Text, out double bedrag5kost);
            double.TryParse(bedragKost6box.Text, out double bedrag6kost);
            double.TryParse(bedragKost7box.Text, out double bedrag7kost);
            double.TryParse(bedragKost8box.Text, out double bedrag8kost);
            double.TryParse(bedragKost9box.Text, out double bedrag9kost);
            double.TryParse(bedragKost10box.Text, out double bedrag10kost);
            double.TryParse(bedragKost11box.Text, out double bedrag11kost);
            double.TryParse(bedragKost12box.Text, out double bedrag12kost);
            double.TryParse(bedragKost13box.Text, out double bedrag13kost);
            double.TryParse(bedragKost14box.Text, out double bedrag14kost);
            double.TryParse(bedragKost15box.Text, out double bedrag15kost);
            double.TryParse(bedragKost16box.Text, out double bedrag16kost);
            double.TryParse(bedragKost17box.Text, out double bedrag17kost);
            double.TryParse(bedragKost18box.Text, out double bedrag18kost);
            double.TryParse(bedragKost19box.Text, out double bedrag19kost);
            double.TryParse(bedragKost20box.Text, out double bedrag20kost);
            double.TryParse(bedragKost21box.Text, out double bedrag21kost);
            double.TryParse(bedragKost22box.Text, out double bedrag22kost);
            double.TryParse(bedragKost23box.Text, out double bedrag23kost);
            double.TryParse(bedragKost24box.Text, out double bedrag24kost);
            double.TryParse(bedragKost25box.Text, out double bedrag25kost);
            double.TryParse(bedragKost26box.Text, out double bedrag26kost);
            double.TryParse(bedragKost27box.Text, out double bedrag27kost);
            double.TryParse(bedragKost28box.Text, out double bedrag28kost);


            //Sum Profit
            sominkomen = (bedrag1Inkomen + bedrag2Inkomen + bedrag3Inkomen +
                bedrag4Inkomen + bedrag5Inkomen + bedrag6Inkomen + bedrag7Inkomen +
                bedrag8Inkomen + bedrag9Inkomen + bedrag10Inkomen + bedrag11Inkomen +
                bedrag12Inkomen + bedrag13Inkomen + bedrag14Inkomen + bedrag15Inkomen +
                bedrag16Inkomen + bedrag17Inkomen + bedrag18Inkomen + bedrag19Inkomen +
                bedrag20Inkomen + bedrag21Inkomen + bedrag22Inkomen + bedrag23Inkomen +
                bedrag24Inkomen + bedrag25Inkomen + bedrag26Inkomen + bedrag27Inkomen +
                bedrag28Inkomen);


            //Sum Cost
            somkost = (bedrag1kost + bedrag2kost + bedrag3kost +
                bedrag4kost + bedrag5kost + bedrag6kost + bedrag7kost +
                bedrag8kost + bedrag9kost + bedrag10kost + bedrag11kost +
                bedrag12kost + bedrag13kost + bedrag14kost + bedrag15kost +
                bedrag16kost + bedrag17kost + bedrag18kost + bedrag19kost +
                bedrag20kost + bedrag21kost + bedrag22kost + bedrag23kost +
                bedrag24kost + bedrag25kost + bedrag26kost + bedrag27kost +
                bedrag28kost);


            string filePath5 = Directory.GetCurrentDirectory();
            string dbPath5 = System.IO.Path.Combine(filePath5, $"DATA");
            string inputFile5 = System.IO.Path.Combine(dbPath5, "LaatsteMaandWinst.txt");
            System.IO.Directory.CreateDirectory(dbPath5);

            string text = File.ReadAllText(inputFile5);
            laatsteMaandwinst = double.Parse(text);

            #endregion


            #region If&Elses
            if ((sominkomen - somkost) > 0)
                answer = profit;
            else
                answer = loss;



            if (sominkomen == 0 && somkost == 0)
                MessageBox.Show("Je moet een veld invullen");
            else if (laatsteMaandwinst > 7000)
                MessageBox.Show("Je hebt al de maximale jaarwinst behaald");
            else if (laatsteMaandwinst <= 7000 && laatsteMaandwinst + (sominkomen - somkost) <= 7000)
            {
                SendMailAlert();
                myWebBrowser.Visibility = Visibility.Visible;
                MessageBox.Show($"Je kan nog € {availableProfitToMakeInEuro} verdienen ");
            }
            else
                MessageBox.Show($"Het resultaat gaat € {Math.Round(laatsteMaandwinst + (sominkomen - somkost) - 7000),2} over de maximale jaarwinst van € 7000");

            ClearsTextBoxes(this);
            #endregion

            van7000winstLbl.Content = $"€ { laatsteMaandwinst} van € 7000 verdient";
        }

        void SendMailAlert()
        {
            try
            {
                string filePath4 = Directory.GetCurrentDirectory();
                string dbPath4 = System.IO.Path.Combine(filePath4, $"DATA");
                string inputFile4 = System.IO.Path.Combine(dbPath4, "Geschiedenis.txt");
                System.IO.Directory.CreateDirectory(dbPath4);

                StreamWriter writer3 = new StreamWriter(inputFile4, true);
                writer3.WriteLine($"\nRapport JS Coaching  || {DateTime.Now.ToString("dd-MM-yyyy")}|| {DateTime.Now.ToString("HH:mm:ss")}");
                writer3.WriteLine($"-----------------------------------------------------------");
                writer3.WriteLine($"Inkomen: € {sominkomen}");
                writer3.WriteLine($"Kosten: € { somkost}");
                writer3.WriteLine($"{answer}: € {Math.Abs(sominkomen - somkost)}");
                writer3.Close();


                string filePath5 = Directory.GetCurrentDirectory();
                string dbPath5 = System.IO.Path.Combine(filePath5, $"DATA");
                string inputFile5 = System.IO.Path.Combine(dbPath5, "LaatsteMaandWinst.txt");
                System.IO.Directory.CreateDirectory(dbPath5);

                dezeMaandwinst = (sominkomen - somkost);
                

                string text = File.ReadAllText(inputFile5);
                laatsteMaandwinst = double.Parse(text);


                if ((laatsteMaandwinst + sominkomen) - somkost < 0)
                {
                    availableProfitToMakeInEuro = 7000;
                    procentOf7000 = (((laatsteMaandwinst + sominkomen) - somkost) / 7000 * 100);
                }
                else
                {
                    availableProfitToMakeInEuro = 7000 - ((laatsteMaandwinst + sominkomen) - somkost);
                    procentOf7000 = (((laatsteMaandwinst + sominkomen) - somkost) / 7000 * 100);
                }

                StreamWriter writer2 = new StreamWriter(inputFile5, false);
                writer2.WriteLine(laatsteMaandwinst + dezeMaandwinst);
                writer2.Close();


                string text2 = File.ReadAllText(inputFile5);
                laatsteMaandwinst = double.Parse(text2);

                van7000winstLbl.Content = $"€ {laatsteMaandwinst} van € 7000 verdient";



                #region MailThatGetsSent
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.IsBodyHtml = true;
                mail.From = new MailAddress("ethereumchecker@gmail.com");
                mail.To.Add("jarne.staal9@gmail.com");
                //mail.To.Add("jadestaaal@outlook.com");
                mail.Subject = $"Rapport JS Coaching  || {DateTime.Now.ToString("d-M-yyyy")}";
                mail.Body = "<head><style>.block {padding: 20px; background: #c0f3f6; border-radius: 2em; text-align: center;} img {display: flex; margin: auto;}</style></head>" +
                    "<body><img src = \"https://media.discordapp.net/attachments/386448776698789900/807563927558946826/lifecoachLogo.webp\" alt = \"JSCOACHING LOGO\"> <div class=\"block\"> <h1>Beginresultaat</h1>" +
                    $"<br>Inkomen: <b>€ {sominkomen}</b> " +
                    $"<br>Kosten: <b>€ {somkost}</b>" +
                    $"<br><br><h1>Eindresultaat</h1>{answer}: <b>€ {Math.Round(Math.Abs(sominkomen - somkost), 2)}</b>" +
                    $"<br>Wat je nog mag verdienen dit jaar: <b>€ {availableProfitToMakeInEuro}</b>" +
                    $"<br>Je hebt tot nu toe <b>€ {laatsteMaandwinst}</b> van de <b>€ 7000</b> verdient. Dat is <b>{Math.Round(procentOf7000, 2)}</b> %" +
                    $"</div> </body>";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ethereumchecker@gmail.com", "nu61*WK12");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sounds\correctSound.wav");
                player.Play();
                MessageBox.Show("Mail Verstuurd!");

                #endregion

                #region ContentinProgram
                MailMessage mail2 = new MailMessage();
                mail2.IsBodyHtml = true;
                mail2.Body = "<head> <link href=\"https://fonts.googleapis.com/css2?family=Poppins&amp;display=swap\" rel =\"stylesheet\">" +
                    "<meta charset=\"UTF-8\"> " +
                    "<style>html {margin: 0; } " +
                    ".block {width: 100%; height: 100%;  text-align: center;} body {font-family: 'Calibri', sans-serif;} .block h1 {padding-top: 10px;} .margin {margin-top=-1em;} " +
                    "img {display: flex; margin: auto;}</style></head>" +
                "<body><div class=\"block\"> <h1>Beginresultaat</h1>" +
                    $"<div class=\"margin\" ><br>Inkomen: <b>€ {sominkomen}</b> " +
                    $"<br>Kosten: <b>€ {somkost}</b></div>" +
                    $"<br><br><h1>Eindresultaat</h1>{answer}: <b>€ {Math.Round(Math.Abs(sominkomen - somkost), 2)}</b>" +
                    $"<br>Wat je nog mag verdienen dit jaar: <b>€ {availableProfitToMakeInEuro}</b>" +
                    $"<br>Je hebt tot nu toe <b>€ {laatsteMaandwinst}</b> van de <b>€ 7000</b> verdient. Dat is <b>{Math.Round(procentOf7000, 2)}</b> %" +
                    $"</div> </body>";

                myWebBrowser.NavigateToString(mail2.Body);

                #endregion

                if (laatsteMaandwinst > 7000)
                    MessageBox.Show("Het maximale winstbedrag van € 7000 is overschreden. Probeer het opnieuw",
                        "Winstbedrag overschreden",
                         MessageBoxButton.OK, MessageBoxImage.Error);

                else if (laatsteMaandwinst == 7000)
                    MessageBox.Show("Het maximale winstbedrag van € 7000 is behaald");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        private void Hersel_Eindbedrag(object sender, RoutedEventArgs e)
        {
            #region Resetting Value
            string filePath5 = Directory.GetCurrentDirectory();
            string dbPath5 = System.IO.Path.Combine(filePath5, $"DATA");
            string inputFile5 = System.IO.Path.Combine(dbPath5, "LaatsteMaandWinst.txt");
            System.IO.Directory.CreateDirectory(dbPath5);

            StreamWriter writer7 = new StreamWriter(inputFile5, false);
            writer7.WriteLine(resetBedrag);
            writer7.Close();

            #endregion

            #region WrongDataEmailSender
            MailMessage mail2 = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail2.IsBodyHtml = true;
            mail2.From = new MailAddress("ethereumchecker@gmail.com");
            mail2.To.Add("jarne.staal9@gmail.com");
            //mail2.To.Add("jadestaaal@outlook.com");
            mail2.Subject = $"BELANGRIJKE MEDEDELING!!!";
            mail2.Body = "<head><style>.block {padding: 20px; background: #c0f3f6; border-radius: 2em; text-align: center;} img {display: flex; margin: auto;} b {font-size: 20px;} </style></head>" +
                    "<body><img src = \"https://media.discordapp.net/attachments/386448776698789900/807563927558946826/lifecoachLogo.webp\" alt = \"JSCOACHING LOGO\"> <div class=\"block\"> <h1>MEDEDELING</h1>" +
                    $"<b>De vorige mail bevat verkeerde informatie.<br> De volgende mail bevat de juiste.</b></div> </body>";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ethereumchecker@gmail.com", "nu61*WK12");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail2);

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"Sounds\correctSound.wav");
            player.Play();
            MessageBox.Show("Laatste Mail Verkeerd -> Mail Verstuurd!");
            #endregion

            ClearsTextBoxes(this);

            van7000winstLbl.Content = $"€ { resetBedrag} van € 7000 verdient";
        }

        private void ClearsTextBoxes(DependencyObject parentDependencyObject)
        {
            int visualChildrenCount = VisualTreeHelper.GetChildrenCount(parentDependencyObject);
            for (int i = 0; i < visualChildrenCount; i++)
            {
                // Retrieve child visual 
                DependencyObject dependencyObject = VisualTreeHelper.GetChild(parentDependencyObject, i);

                TextBox textBox = dependencyObject as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
                else
                {
                    ClearsTextBoxes(dependencyObject);
                }
            }
        }


        void wb_LoadCompleted(object sender, NavigationEventArgs e)
        {
            string script = "document.body.style.overflow ='hidden'";
            WebBrowser wb = (WebBrowser)sender;
            wb.InvokeScript("execScript", new Object[] { script, "JavaScript" });
        }

        private void Unlock2ndRowIncome(object sender, RoutedEventArgs e)
        {

            if (bedragInkomen14box.Text == "" || bedragInkomen14box.Text == "0")
                SecondRowIncome.Visibility = Visibility.Hidden;
            else
                SecondRowIncome.Visibility = Visibility.Visible;
        }

        private void SecondRowCostUnlock(object sender, TextChangedEventArgs e)
        {
            if (bedragKost14box.Text == "" || bedragKost14box.Text == "0")
                SecondRowCost.Visibility = Visibility.Hidden;
            else
                SecondRowCost.Visibility = Visibility.Visible;
        }
        private void WisTextBoxes(object sender, RoutedEventArgs e)
        {
            ClearsTextBoxes(this);
            myWebBrowser.Visibility = Visibility.Hidden;
        }
    }
}
