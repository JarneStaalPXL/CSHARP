using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Microsoft.VisualBasic;
using System.Linq;



namespace BSS3
{
    /// -----------------------------------------
    /// Author: Jarne Staal
    /// Create Date: 12/12/2020
    /// Description: Blad Steen Schaar 3
    /// -----------------------------------------
    public partial class MainWindow : Window
    {
        #region Strings/Ints/Vars/Lists/Randomisers
        //Strings 
        private string Computer;
        private string[] answers = { "Rock", "Paper", "Scissors" };
        private string playerchose;
        private string computer = "Computer";
        private string player = "Speler";
        private string draw = "Gelijkspel";
        private string wins = " wint";
        private string user = "";


        //Ints
        private int scoreplayer = 0;
        private int scorepc = 0;
        private int counter = 3;
        private int gameSession = 1;

        //ChoicesForHistory
        private int playerchoseRock = 0;
        private int playerchosePaper = 0;
        private int playerchoseScissors = 0;

        private int pcChoseRock = 0;
        private int pcChosePaper = 0;
        private int pcChoseScissors = 0;

        //Random
        Random random = new Random();
        private int randomanswer = 0;

        #endregion


        #region Clock 
        public MainWindow()
        {
            InitializeComponent(); 
            
            

            //Clock
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("HH:mm:ss")}";
            },
            this.Dispatcher);

            

            //Run Timer Method
            Timer2();

        
        }
        #endregion


        #region Timers
        private DispatcherTimer timer1;
        private void Timer2()//Counter startup
        {
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();

            if (counter <= 3)
            {
                count3.Content = counter.ToString();
            }
        }

        /// <summary>
        /// Counts down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                count3.Content = "";  //Prevent timer for showing 0 the whole time after countdown
                result.Content = "Tijd is op: " + computer + wins;
                scorepc++;
                scorepc1.Content = ($"COMPUTER {scorepc}");
                counter = 4;
                timer1.Start();

                //Show Clock when times up 
                Image imgd = new Image();
                imgd.Source = new BitmapImage(new Uri(@"images\clock.png", UriKind.RelativeOrAbsolute));
                count3.Content = imgd;

                //Remove the two images 
                Empty();
            }
            else
            {
                count3.Content = counter.ToString();
            }
        }
        #endregion


        #region Clears Choice
        /// <summary>
        /// Clears choice of player and pc
        /// </summary>
        void Empty()
        {
            playerchoice.Content = "";
            pcchoice.Content = "";
            ColorBG();
        }
        #endregion


        #region Score
        /// <summary>
        /// Sets the score of player and pc
        /// </summary>
        void setcurrentscore()
        {
            scoreplayer1.Content = ($"SPELER {scoreplayer}");
            scorepc1.Content = ($"COMPUTER {scorepc}");
        }
        /// <summary>
        /// Sets the score of player and pc to zero
        /// </summary>
        void scorezero()
        {
            scoreplayer1.Content = ($"SPELER {0}");
            scorepc1.Content = ($"COMPUTER {0}");
            scoreplayer = 0;
            scorepc = 0;
        }
        #endregion


        #region Brushes

        /// <summary>
        /// Changes borderbrush to black
        /// </summary>
        void ChangeBorderBrushButton1()
        {
            if (button1.BorderBrush == Brushes.Gray)
            {
                button1.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Changes borderbrush to black
        /// </summary>
        void ChangeBorderBrushButton2()
        {
            if (button2.BorderBrush == Brushes.Gray)
            {
                button2.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Changes borderbrush to black
        /// </summary>
        void ChangeBorderBrushButton3()
        {
            if (button3.BorderBrush == Brushes.Gray)
            {
                button3.BorderBrush = Brushes.Black;
            }
        }

        /// <summary>
        /// Sets second and third button's borderbrush to gray
        /// </summary>
        void ResetBorderBrush23()
        {
            button2.BorderBrush = Brushes.Gray;
            button3.BorderBrush = Brushes.Gray;
        }

        /// <summary>
        /// Sets first and third button's borderbrush to gray
        /// </summary>
        void ResetBorderBrushButton13()
        {
            button1.BorderBrush = Brushes.Gray;
            button3.BorderBrush = Brushes.Gray;
        }

        /// <summary>
        /// Sets first and second button's borderbrush to gray
        /// </summary>
        void ResetBorderBrush12()
        {
            button1.BorderBrush = Brushes.Gray;
            button2.BorderBrush = Brushes.Gray;
        }


        /// <summary>
        /// Sets color of content background to background color
        /// </summary>
        void ColorBG()
        {
            var bc = new BrushConverter(); //new brush
            playerchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
            pcchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
        }

        /// <summary>
        /// Sets color of content background to gray 
        /// </summary>
        void ColorDraw()
        {
            var bc = new BrushConverter(); //new brush
            playerchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
            pcchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
        }

        #endregion


        #region BSS Game
        /// <summary>
        /// The Rock Paper Scissors-Game
        /// </summary>
        void BSS()
        {
            #region Beginning actions
            timer1.Stop();
            count3.Content = "";
            counter = 3;
            Timer2();
            setcurrentscore();
            #endregion


            #region Images
            //Image Rock
            Image imga = new Image();
            imga.Source = new BitmapImage(new Uri(@"images\Steen.png", UriKind.RelativeOrAbsolute));

            //Image Paper
            Image imgb = new Image();
            imgb.Source = new BitmapImage(new Uri(@"images\Blad.png", UriKind.RelativeOrAbsolute));

            //Image Scissors
            Image imgc = new Image();
            imgc.Source = new BitmapImage(new Uri(@"images\Schaar.png", UriKind.RelativeOrAbsolute));
            #endregion


            #region Winners/Losers & Actions

            var bc = new BrushConverter(); //new brush
            if (playerchose == "Rock" && Computer == "Paper") // Player: Rock, Computer: Paper = computer wins
            {
                playerchoseRock++;
                pcChosePaper++;
                result.Content = computer + wins;
                scorepc++;

                //PlayerChoice Rock
                playerchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                playerchoice.Content = imga;

                //PcChoice Paper
                pcchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                pcchoice.Content = imgb;
            }
            else if (playerchose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                playerchoseRock++;
                pcChoseScissors++;
                result.Content = player + wins;
                scoreplayer++;

                //PlayerChoice Rock
                playerchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                playerchoice.Content = imga;

                //PcChoice Scissors
                pcchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                pcchoice.Content = imgc;
            }
            else if (playerchose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                playerchosePaper++;
                pcChoseScissors++;
                result.Content = computer + wins;
                scorepc++;

                //PlayerChoice Paper
                playerchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                playerchoice.Content = imgb;

                //PcChoice Scissors
                pcchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                pcchoice.Content = imgc;
            }
            else if (playerchose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                playerchosePaper++;
                pcChoseRock++;
                result.Content = player + wins;
                scoreplayer++;

                //PlayerChoice Paper
                playerchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                playerchoice.Content = imgb;

                //PcChoice Rock
                pcchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                pcchoice.Content = imga;
            }
            else if (playerchose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                playerchoseScissors++;
                pcChoseRock++;
                result.Content = computer + wins;
                scorepc++;

                //PlayerChoice Scissors
                playerchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                playerchoice.Content = imgc;

                //PcChoice Rock
                pcchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                pcchoice.Content = imga;
            }
            else if (playerchose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                playerchoseScissors++;
                pcChosePaper++;
                result.Content = player + wins;
                scoreplayer++;

                //PlayerChoice Scissors
                playerchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
                playerchoice.Content = imgc;

                //PcChoice Paper
                pcchoice.Background = (Brush)bc.ConvertFrom("#c22a25");
                pcchoice.Content = imgb;
            }

            else if (playerchose == "Scissors" && Computer == "Scissors")
            {
                playerchoseScissors++;
                pcChoseScissors++;

                result.Content = draw;
                ColorDraw();

                playerchoice.Content = imgc;
                Image copyImgc = new Image();
                copyImgc.Source = imgc.Source;
                pcchoice.Content = copyImgc;
            }
            else if (playerchose == "Paper" && Computer == "Paper")
            {
                playerchosePaper++;
                pcChosePaper++;

                result.Content = draw;
                ColorDraw();

                playerchoice.Content = imgb;
                Image copyImgb = new Image();
                copyImgb.Source = imgb.Source;
                pcchoice.Content = copyImgb;
            }
            else if (playerchose == "Rock" && Computer == "Rock")
            {
                playerchoseRock++;
                pcChoseRock++;
                result.Content = draw;
                ColorDraw();
                playerchoice.Content = imga;
                Image copyImga = new Image();
                copyImga.Source = imga.Source;
                pcchoice.Content = copyImga;
            }
            setcurrentscore();

            #endregion


            #region Messages/SaveToListBox

            List<string> list = new List<string>();

            void MsgYesNoPLAYER() //Show msgbox content // Questions to continue to play or not
            {
                MessageBoxResult answer = MessageBox.Show("Wilt u opnieuw spelen?", "Proficiat, u wint!",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (answer == MessageBoxResult.Yes)
                {
                    string inputname = Interaction.InputBox("Geef uw naam in",
                                                               "Winnaar!",
                                                                "",
                                                                500);
                    if (inputname == "")
                    {
                        user = "Anonieme Speler";
                        list.Add($"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})");
                        listbox1.Items.Add($"{list[0]}");
                            

                    }
                    if (inputname != "")
                    {
                        user = inputname;
                        list.Add($"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})");
                        listbox1.Items.Add($"{list[0]}");
                        
                    }              

                    SaveHistoryToFile();
                    BSS();
                    scorezero();
                    ColorBG();
                    Empty();
                    ResetBorderBrush12();
                    ResetBorderBrush23();
                    ResetBorderBrushButton13();
                }
                else if (answer == MessageBoxResult.No)
                {
                    System.Environment.Exit(0);
                }
            }
            
            void MsgYesNoPC() //Show msgbox content // Questions to continue to play or not
            {
                MessageBoxResult answer = MessageBox.Show("Wilt u opnieuw spelen?", "Spijtig, de computer wint",
                    MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (answer == MessageBoxResult.Yes)
                {
                    string inputname = Interaction.InputBox("Geef uw naam in",
                                                              "Verloren!",
                                                               "",
                                                               500);
                    if (inputname == "")
                    {
                        user = "Anonieme Speler";
                        list.Add($"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})");
                        listbox1.Items.Add($"{list[0]}");
                        
                    }
                    else if (inputname != "")
                    {
                        user = inputname;
                        list.Add($"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})");
                        listbox1.Items.Add($"{list[0]}");
                        
                    }
                    SaveHistoryToFile();
                    BSS();
                    scorezero();
                    ColorBG();
                    Empty();
                    ResetBorderBrush12();
                    ResetBorderBrush23();
                    ResetBorderBrushButton13();
                }
                if (answer == MessageBoxResult.No)
                {
                    System.Environment.Exit(0);
                }
            }
            #endregion


            #region Actions when score is 10
            if (scoreplayer == 10)
            {
                timer1.Stop();
                count3.Content = "";
                ColorBG();
                Empty();
                MsgYesNoPLAYER();
                scorezero();
                ResetHistoryChoices();
                gameSession++;
            }
            else if (scorepc == 10)
            {
                timer1.Stop();
                count3.Content = "";
                Empty();
                MsgYesNoPC();
                scoreplayer = 0;
                scorepc = 0;
                scorezero();
                ColorBG();
                ResetHistoryChoices();
                gameSession++;
            }
            #endregion

        }
        #endregion


        #region Button Clicks
        /// <summary>
        /// Button Click Paper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaperClick(object sender, RoutedEventArgs e)
        {
            playerchose = "Paper";
            randomanswer = random.Next(0, 3);
            Computer = answers[randomanswer];
            ChangeBorderBrushButton1();
            ResetBorderBrush23();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        /// <summary>
        /// Button Click Rock 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RockClick(object sender, RoutedEventArgs e)
        {
            playerchose = "Rock";
            randomanswer = random.Next(0, 3);
            Computer = answers[randomanswer];
            ChangeBorderBrushButton2();
            ResetBorderBrushButton13();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        /// <summary>
        /// Button Click Scissors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScissorsClick(object sender, RoutedEventArgs e)
        {
            playerchose = "Scissors";
            randomanswer = random.Next(0, 3);
            Computer = answers[randomanswer];
            ChangeBorderBrushButton3();
            ResetBorderBrush12();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        /// <summary>
        /// Resets game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScoreReset(object sender, RoutedEventArgs e)
        {
            ScoreReset();
        }

        void ScoreReset ()
        {
            counter = 4;
            count3.Content = "";
            scorezero();
            ColorBG();
            Empty();
            ResetBorderBrush12();
            ResetBorderBrush23();
            ResetBorderBrushButton13();
            ResetHistoryChoices();
        }

        /// <summary>
        /// Opens scores in notepad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opens_Results(object sender, RoutedEventArgs e)
        {
            FileInfo file = new FileInfo($@"RESULTS {DateTime.Now.ToString("d-M-yyyy")}\ScoreList.txt");
            if (file.Exists == false || new FileInfo($@"RESULTS {DateTime.Now.ToString("d-M-yyyy")}\ScoreList.txt").Length == 0)
            {
                timer1.Stop();
                MessageBox.Show("  Je moet eerst een spel spelen"+"                                                  "+
                    "voordat je de resultaten kunt zien." +
                    " \n\n   Klik op OK om het spel te hervatten.", "                                              Foutmelding",
                    MessageBoxButton.OK, MessageBoxImage.Error);

                timer1.Start();
            }
            else
            {
                timer1.Stop();
                Process notepad = new Process();
                Process.Start("notepad", Directory.GetCurrentDirectory() + $@"\RESULTS {DateTime.Now.ToString("d-M-yyyy")}\ScoreList.txt");

                MessageBoxResult msgboxplay =  MessageBox.Show("Wilt u het spel hervatten?","Welkom terug!", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (msgboxplay == MessageBoxResult.Yes)
                {
                    timer1.Start();
                }
                else if (msgboxplay == MessageBoxResult.No)
                {
                    System.Environment.Exit(0);
                } 
            } 
        }
        #endregion


        #region History

        /// <summary>
        /// Sets the scores for history of player
        /// </summary>
        void HistoryPlayerChoices()
        {
            historyplayer.Content = $"Blad: {playerchosePaper} " +
            $"Steen: {playerchoseRock} " +
            $"Schaar: {playerchoseScissors}";
        }

        /// <summary>
        /// Sets the scores for history of pc
        /// </summary>
        void HistoryPCChoices()
        {
            historypc.Content = $"Blad: {pcChosePaper} " +
            $"Steen: {pcChoseRock} " +
            $"Schaar: {pcChoseScissors}";
        }

        /// <summary>
        /// Resets history content and values
        /// </summary>
        void ResetHistoryChoices()
        {
            playerchosePaper = 0;
            playerchoseRock = 0;
            playerchoseScissors = 0;

            pcChosePaper = 0;
            pcChoseRock = 0;
            pcChoseScissors = 0;

            historyplayer.Content = $"Blad: {0} " +
            $"Steen: {0} " +
            $"Schaar: {0}";

            historypc.Content = $"Blad: {0} " +
            $"Steen: {0} " +
            $"Schaar: {0}";
        }
        #endregion


        #region SavingHistoryToFile(Extra)
        /// <summary>
        /// Saves score history to local txt file
        /// </summary>
        private void SaveHistoryToFile()
        {
            DateTime date2 = DateTime.Now;

            string filePath = Directory.GetCurrentDirectory();
            string dbPath = System.IO.Path.Combine(filePath, $"RESULTS {DateTime.Now.ToString("d-M-yyyy")}");
            string inputFile = System.IO.Path.Combine(dbPath, "ScoreList.txt");
            System.IO.Directory.CreateDirectory(dbPath);

            StreamWriter writer = new StreamWriter(inputFile, true);
            writer.WriteLine($"\n------------------SESSION {gameSession}------------------ \n                  {date2.ToString("d-MM-yyyy")} \n");
            writer.WriteLine($"{user} - Computer {scoreplayer} - {scorepc}  ({date2.ToString("HH:mm:ss")})");
            writer.Close();
        }

        #endregion
    }
}