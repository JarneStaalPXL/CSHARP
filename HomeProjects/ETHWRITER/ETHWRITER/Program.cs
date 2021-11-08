using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Web;
using System.Text;
using static ETHWRITER.Account;
using System.Net.Mail;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Media;

namespace ETHWRITER
{
    public class Account
    {
        public partial class CryptoCurrencyListing
        {
            public Datum[] Data { get; set; }
        }

        public partial class Datum
        {
            public string Symbol { get; set; }

            public Dictionary<string, Quote> Quote { get; set; }
        }

        public partial class Quote
        {
            public double Price { get; set; }
        }
    }
    class Program
    {
        #region Int/Strings/Bools
        private static int SIZE_ARRAY = 13;
        private static string[] array = new string[13]
        { "2d5bc2b9-f563-4339-97da-cb75c3d36e36",
            "a99a1119-f9fe-4025-98dc-3bb95a6d49a4",
            "5e2465f3-bfe1-4dab-8fb9-033099720b8e",
            "1888cafb-023f-453b-9440-a6be6f2ae192",
            "196384f1-bcc9-4434-a353-ad3be569ff5d",
            "8211a2d8-5ffc-4a2b-840e-5804aa8cd2b3",
            "89046fe8-612a-4854-95d9-4ad88fc89416",
        "4f640847-4ff5-4d8e-84a2-92c92a974485",
            "eb837bd8-069e-45e9-b35f-f70897779e20",
            "0ec4c183-0fdd-43c7-8249-076a790af6ca",
            "9b35a40e-d3d2-445b-807b-e6ac36806831",
            "088ba1e6-cb4c-455b-85b5-9b2fdb1fdd24",
            "96672745-eab9-48a3-8dbd-dd588460b259"};
        private static string API_KEY = array[0];
        private static double walletamount = 0;
        private static string inputvalue = "";
        private static string typeOfAlertText = string.Empty;
        private static int positiveAction = 0;
        private static int negativeAction = 0;
        private static bool buySignal;
        private static bool sellSignal;
        private static int number;
        public static int count;
        private static double ethPrice;
        private static string emailInput;
        private static string strComputerName;
        private static int alertLimit;
        private static bool bar;
        private static string answer;
        private static double inputval = 0; 
        private static double historyWalletAmount;
        #endregion

        #region filePaths
        private static string filepath = @"lastETHPrice.txt";
        private static string filepathHistory = $@"HistoryPrice({DateTime.Now.ToString("dd-MM-yyyy")}).csv";
        private static string filepathBuySell = $@"BuySell5min({DateTime.Now.ToString("dd-MM-yyyy")}).csv";
        #endregion

        #region Users
        private static List<string> codes = new List<string>()
        { "DESKTOP-7TSFPEJ",
            "WINDOWS-SSGHMMT",
            "DESKTOP-D0GRDPU",
            "PF2B3Y6V" };
        #endregion

        static void Main(string[] args)
        {
            //TimeScalePicker();
            Console.OutputEncoding = Encoding.Default;

            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            else
            {
                #region If File Doesn't Exist
                if (!File.Exists(filepath))
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        sw.Write("");
                    }
                }
                if (!File.Exists(filepathHistory))
                {
                    using (StreamWriter sw = new StreamWriter(filepathHistory))
                    {
                        sw.Write("");
                    }
                }
                if (!File.Exists(filepathBuySell))
                {
                    using (StreamWriter sw = new StreamWriter(filepathBuySell))
                    {
                        sw.Write("");
                    }
                    
                }
                #endregion

                strComputerName = Environment.MachineName.ToString();

                if (codes.Contains(strComputerName))
                {
                    Console.WriteLine("Client Identified\n");
                    Console.WriteLine("Do you want the signals to be sent to your email? Y/N");
                    answer = Console.ReadLine();
                    if (answer.ToUpper().Equals("Y"))
                    {
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Client Identified\n");
                            Console.Write("Insert Email: ");
                            ConsoleColorSet("Green");
                            emailInput = Console.ReadLine();
                            Console.Clear();
                            ConsoleColorSet("White");

                            var foo = new EmailAddressAttribute();
                            bar = foo.IsValid(emailInput);
                            if (new EmailAddressAttribute().IsValid(emailInput))
                                bar = true;

                        } while (bar == false);
                    }

                    Console.WriteLine("Starting up predictor .... ");
                    Console.WriteLine("(This will take 5 minutes)");

                    while (true)
                    {
                        buySignal = false;
                        sellSignal = false;

                        if (positiveAction >= 6 || negativeAction >= 6)
                        {
                            positiveAction = 0;
                            negativeAction = 0;
                        }

                        //Thread.Sleep(5000);
                        Thread.Sleep(300000);
                        //Thread.Sleep(600000);


                        Console.Clear();
                        setApiKey();
                        Calculations();
                        double.TryParse(inputvalue, out inputval);

                        //Console.WriteLine($"\n\nCurrently chosen timescale in ms = {number}");
                        Console.WriteLine($"\n\nCurrently used API Key : {API_KEY}");
                        Console.WriteLine($"--------------------------------------------------------------------------------------------------\n");
                        Console.Write("Refreshing every 5 minutes ...");
                    }
                }
                else
                {
                    Console.Write("Please buy an activation from the owner. \nTo do this, contact");
                    ConsoleColorSet("Blue");
                    Console.Write(" RTXPower#2855");
                    ConsoleColorSet("White");
                    Console.Write(" on Discord\n\n\n");
                }
            }
        }

        static void ConsoleColorSet(string color)
        {
            if (Enum.TryParse(color, out ConsoleColor foreground))
            {
                Console.ForegroundColor = foreground;
            }
        }

        static void TimeScalePicker()
        {
            Console.Clear();

            Console.WriteLine("At what timescale do you want result?");
            Console.WriteLine("For 1min please enter 60000");
            Console.WriteLine("For 3min please enter 180000");
            Console.WriteLine("For 5min please enter 300000");
            Console.WriteLine("For 15min please enter 900000  (NOT RECOMMENDED)");
            Console.WriteLine("For 30min please enter 1800000 (NOT RECOMMENDED)");
            Console.Write("Your chosen timescale: ");
            number = int.Parse(Console.ReadLine());

            if (number != 60000 && number != 180000 && number != 300000 && number != 900000 && number != 1800000)
            {
                TimeScalePicker();
            }
        }

        
        public static void Calculations()
        {

            #region ETH Price Tracking & Saving

            string lastEthPriceString = File.ReadAllText(filepath);
            double.TryParse(lastEthPriceString, out double lastEthPrice);
            string json = string.Empty;

            json = makeAPICall();

            count++;

            CryptoCurrencyListing cryptoCurrencyListing = JsonConvert.DeserializeObject<CryptoCurrencyListing>(json);
            Datum symbol = cryptoCurrencyListing.Data.FirstOrDefault(d => d.Symbol == "ETH");
            Quote quote = symbol.Quote["EUR"];

            // get the price
            double price = quote.Price;

            double EthValue = 8.33273612;
            double investedValue = 3500;
            ethPrice = quote.Price;
           
            historyWalletAmount = walletamount;
            walletamount = EthValue * ethPrice;

            double gain = walletamount / investedValue;
            double loss = investedValue - walletamount;
            var result = Math.Round((walletamount - investedValue) / investedValue * 100, 0);
            double profit =  Math.Round(walletamount - investedValue, 0);

            if (IsFileLocked() == false)
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.WriteLine(ethPrice);
                }

                using (StreamWriter sw = new StreamWriter(filepathHistory, true))
                {
                    sw.Write($"{ethPrice};");
                }
            }
            
            
            ConsoleColorSet("White");
            Console.WriteLine($"ETH PRICE: {Math.Round(ethPrice, 2).ToString()}  EURO");
            //Console.WriteLine($"WALLET AMOUNT: {Math.Round(walletamount, 2).ToString()} EURO");

            #endregion

            #region Algorythm
            if (count >= 1)
            {
                if (negativeAction >= 5)
                    alertLimit = 7;
                else
                    alertLimit = 5;


                if (ethPrice < lastEthPrice)
                {
                    negativeAction++;
                    ConsoleColorSet("Red");
                    if (walletamount - investedValue > 0)
                    {
                        //OPTIONAL (Use ETH CHECKER FOR THIS)
                        //Console.WriteLine($"Profit: {profit} EURO");
                        //Console.WriteLine($"Profit: {result} %");
                    }
                    else if (walletamount - investedValue < 0)
                    {
                        //OPTIONAL (Use ETH CHECKER FOR THIS)
                        //Console.WriteLine($"Loss: € {Math.Round(loss, 0)}");
                        //Console.WriteLine($"{Math.Round(loss / investedValue * 100)} %");
                    }
                   
                    Console.WriteLine("\n                                                          DOWN\n");
                    if (negativeAction >= alertLimit) 
                    {
                            Console.WriteLine("\n                                                          SELL");
                            buySignal = false;
                            sellSignal = true;
                    }
                }
                else
                {
                    positiveAction++;
                    ConsoleColorSet("Green");
                    if (walletamount - investedValue > 0)
                    {
                        //Console.WriteLine($"Profit: {profit} EURO");
                        //Console.WriteLine($"Profit: {result} %");
                    }
                    else if (walletamount - investedValue < 0)
                    {
                        //Console.WriteLine($"Loss: {Math.Round(loss, 0)} EURO");
                        //Console.WriteLine($"{Math.Round(loss / investedValue * 100)} %");
                    }

                    Console.WriteLine("\n                                                          UP\n");
                    if (positiveAction >= alertLimit)
                    {
                            Console.WriteLine("\n                                                          BUY");
                            buySignal = true;
                            sellSignal = false;
                    }
                }
            }

            #region API&Momentum
            ConsoleColorSet("White");
            Console.WriteLine($"\nMade {count} API Calls this session");

            Console.Write($"\nBullish momentum ");
            ConsoleColorSet("Green");
            Console.Write(positiveAction);

            ConsoleColorSet("White");
            Console.Write($"\nBearish momentum ");
            ConsoleColorSet("Red");
            Console.Write(negativeAction);
            ConsoleColorSet("White");

            #endregion



            if (buySignal == true)
           {
                Console.Write($"\n\nBUY SIGNAL FLASHED AT ");
                ConsoleColorSet("Green");
                Console.Write($"{ethPrice,2} EURO");

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"mywavfile.wav");
                player.Play();


                
                using (StreamWriter sw = new StreamWriter(filepathBuySell, true))
                {
                    sw.WriteLine($"BUY SIGNAL FLASHED AT ;{ethPrice,2};{DateTime.Now.ToString("dd-MM-yyyy HH:mm")}");
                }
                

                ConsoleColorSet("White");
                if (emailInput != string.Empty)
                {
                    SendMailAlert();
                }  
           }
           else if (sellSignal == true)
           {
               Console.Write($"\n\nSELL SIGNAL FLASHED AT ");
               ConsoleColorSet("Red");
               Console.Write($"{ethPrice,2}EURO");

               System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"mywavfile.wav");
               player.Play();

               
               using (StreamWriter sw = new StreamWriter(filepathBuySell, true))
               {
                   sw.WriteLine($"SELL SIGNAL FLASHED AT ;{ethPrice,2};{DateTime.Now.ToString("dd-MM-yyyy HH:mm")}");
               }
               
               

               ConsoleColorSet("White");
               if (emailInput != string.Empty)
               {
                   SendMailAlert();
               }
           }

            #endregion
        }

        public static string makeAPICall()
        {
            var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

            var queryString = HttpUtility.ParseQueryString(string.Empty);
            queryString["start"] = "1";
            queryString["limit"] = "2";
            queryString["convert"] = "EUR";

            URL.Query = queryString.ToString();

            var client = new WebClient();
            client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
            client.Headers.Add("Accepts", "application/json");

            return client.DownloadString(URL.ToString());
        }

        public static bool IsFileLocked()
        {
            try
            {
                using (Stream stream = new FileStream(filepathBuySell, FileMode.Open))

                return false; //if it's able to open the stream -> File not in use by other process

            }
            catch
            {
                return true;
                //check here why it failed and ask user to retry if the file is in use.
            }
        }

        static void SendMailAlert()
        {
            try
            {
                string typeOfSignal = string.Empty;
                if (buySignal == true)
                {
                    typeOfSignal = "Buy Signal";
                    typeOfAlertText = "Buy Signal At ";
                }
                else if (sellSignal == true)
                {
                    typeOfSignal = "Sell Signal";
                    typeOfAlertText = "Sell Signal At ";
                }
                    
                #region MailThatGetsSent
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.IsBodyHtml = true;
                mail.From = new MailAddress("ethereumchecker@gmail.com");
                mail.To.Add(emailInput);
                mail.Subject = $"{typeOfSignal}|| {DateTime.Now.ToString("d-M-yyyy")}";
                mail.Body = "<head><style>.block {padding: 20px; background: #c0f3f6; border-radius: 2em; text-align: center;} img {display: flex; margin: auto;}</style></head>" +
                    "<body><div class=\"block\"> <h1>Signal Alert</h1>" +
                    $"<h4>{typeOfAlertText}{ethPrice}</h4>" +
                    $"</div> </body>";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("ethereumchecker@gmail.com", "nu61*WK12");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);

                Console.WriteLine("\nSignal sent to email!");

                #endregion

            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\nERROR:"+ "Signal cannot be sent to email because of wrong email adress.\nPlease restart software and enter the right email adress");
            }
        }

        static void setApiKey()
        {
            Random rand = new Random();
            API_KEY = array[rand.Next(0, SIZE_ARRAY)];
            Console.WriteLine($"--------------------------------------------------------------------------------------------------\n");
        }
    }
}
