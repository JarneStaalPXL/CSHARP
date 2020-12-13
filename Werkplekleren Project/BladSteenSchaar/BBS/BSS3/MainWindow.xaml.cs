using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Microsoft.VisualBasic;


namespace BSS3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Strings 
        string Computer;
        string[] answers = { "Rock", "Paper", "Scissors" };
        string PlayerChose;
        string computer = "Computer";
        string player = "Speler";
        string draw = "Gelijkspel";
        string wint = " wint";
        string user = "";
        

        //Ints
        private int scoreplayer = 0;
        private int scorepc = 0;
        private int counter = 3;

        //Random
        Random random = new Random();
        int RandomType = 0;

        //ChoicesForHistory
        private int PlayerChoseRock = 0;
        private int PlayerChosePaper = 0;
        private int PlayerChoseScissors = 0;

        private int PCChoseRock = 0;
        private int PCChosePaper = 0;
        private int PCChoseScissors = 0;

        
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
            timer2();

        }

        #region Timers
        private DispatcherTimer timer1;
        private void timer2()//Counter startup
        {
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();

            if (counter <= 3)
            {
                count3.Content = counter.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e) //Counts down
        {
            counter--;
            if (counter == 0)
            {
                timer1.Stop();
                count3.Content = ""; //Prevent timer for showing 0 the whole time after countdown
                result.Content = "Tijd is op: " + computer + wint; //Computer wins and shows message when times up
                scorepc++;
                scorepc1.Content = ($"COMPUTER {scorepc}");
                counter = 4;
                timer1.Start();

                //Show Clock when times up 
                Image imgd = new Image();
                imgd.Source = new BitmapImage(new Uri(@"images\clock.png", UriKind.RelativeOrAbsolute));
                count3.Content = imgd;

                //Remove the two images 
                empty();
            }
            else
            {
                count3.Content = counter.ToString();
            }
        }
        #endregion




        #region Clears Choice
        void empty() //clears choice of player and pc
        {
            playerchoice.Content = "";
            pcchoice.Content = "";
            colorbg();
        }
        #endregion




        #region Score
        void setcurrentscore() //sets the score of player and pc
        {
            scoreplayer1.Content = ($"SPELER {scoreplayer}");
            scorepc1.Content = ($"COMPUTER {scorepc}");
        }

        void scorezero() //sets the score of player and pc to zero
        {
            scoreplayer1.Content = ($"SPELER {0}");
            scorepc1.Content = ($"COMPUTER {0}");
            scoreplayer = 0;
            scorepc = 0;
        }
        #endregion



        #region Messages
        void MsgYesNoPLAYER() //Show msgbox content // Questions to continue to play or not
        {
            MessageBoxResult answer = MessageBox.Show("Would you like to play again?", "Congratulations, You Win", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                string inputname = Interaction.InputBox("Geef uw naam in", 
                                                           "Winnaar!", 
                                                            "", 
                                                            500);

                

                if (inputname == "")
                {
                    user = "Anonieme Speler";
                    
                }
                else
                {
                    user = inputname;
                    
                }

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    sb.Append($"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})\n");
                }
                showhistory.Content = sb;


                BSS();
                scorezero();
                colorbg();
                empty();
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
            MessageBoxResult answer = MessageBox.Show("Would you like to play again?", "Unfortunately, the computer wins", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                string inputname = Interaction.InputBox("Geef uw naam in",
                                                          "Winnaar!",
                                                           "",
                                                           500);

                string tempuser = "";

                if (inputname == "")
                {
                    user = "Anonieme Speler";
                    showhistory.Content = $"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})";
                }
                else
                {
                    user = inputname;
                    showhistory.Content = $"{user} - Computer {scoreplayer} - {scorepc}  ({DateTime.Now.ToString("HH:mm:ss")})";
                }


                BSS();
                scorezero();
                colorbg();
                empty();
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



        #region Brushes
        void ChangeBorderBrushButton1()
        {
            if (button1.BorderBrush == Brushes.Gray)
            {
                button1.BorderBrush = Brushes.Black;
            }
        }

        void ChangeBorderBrushButton2()
        {
            if (button2.BorderBrush == Brushes.Gray)
            {
                button2.BorderBrush = Brushes.Black;
            }
        }

        void ChangeBorderBrushButton3()
        {
            if (button3.BorderBrush == Brushes.Gray)
            {
                button3.BorderBrush = Brushes.Black;
            }
        }

        void ResetBorderBrush23()
        {
            button2.BorderBrush = Brushes.Gray;
            button3.BorderBrush = Brushes.Gray;
        }

        void ResetBorderBrushButton13()
        {
            button1.BorderBrush = Brushes.Gray;
            button3.BorderBrush = Brushes.Gray;
        }

        void ResetBorderBrush12()
        {
            button1.BorderBrush = Brushes.Gray;
            button2.BorderBrush = Brushes.Gray;
        }
        void colorbg()
        {
            var bc = new BrushConverter(); //new brush

            playerchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
            pcchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
        }

        void colordraw()
        {
            var bc = new BrushConverter(); //new brush

            playerchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
            pcchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
        }

        void colorred()
        {
            var bc = new BrushConverter();
            playerchoice.Background = (Brush)bc.ConvertFrom("#c22a25");

        }

        void colorgreen()
        {
            var bc = new BrushConverter();
            pcchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
        }
        #endregion



        #region History
        void HistoryPlayerChoices()
        {
            historyplayer.Content = $"Blad: {PlayerChosePaper} "+
            $"Steen: {PlayerChoseRock} " +
            $"Schaar: {PlayerChoseScissors}";
        }

        void HistoryPCChoices()
        {
            historypc.Content = $"Blad: {PCChosePaper} " +
            $"Steen: {PCChoseRock} " +
            $"Schaar: {PCChoseScissors}";
        }

        void ResetHistoryChoices()
        {
            PlayerChosePaper = 0;
            PlayerChoseRock = 0;
            PlayerChoseScissors = 0;

            PCChosePaper = 0;
            PCChoseRock = 0;
            PCChoseScissors = 0;

            historyplayer.Content = $"Blad: {0} " +
            $"Steen: {0} " +
            $"Schaar: {0}";

            historypc.Content = $"Blad: {0} " +
            $"Steen: {0} " +
            $"Schaar: {0}";
        }
        #endregion



        #region BSS Game
        private void BSS() // The Rock Paper Scissors-game
        {
            
            timer1.Stop();
            count3.Content = "";

            counter = 3;  //Sets counter back to 3
            timer2();
            setcurrentscore();
            

            



            //Image Rock
            Image imga = new Image();
            imga.Source = new BitmapImage(new Uri(@"images\Steen.png", UriKind.RelativeOrAbsolute));

            //Image Paper
            Image imgb = new Image();
            imgb.Source = new BitmapImage(new Uri(@"images\Blad.png", UriKind.RelativeOrAbsolute));

            //Image Scissors
            Image imgc = new Image();
            imgc.Source = new BitmapImage(new Uri(@"images\Schaar.png", UriKind.RelativeOrAbsolute));



            if (PlayerChose == "Rock" && Computer == "Paper") // Player: Rock, Computer: paper = computer wins
            {
                PlayerChoseRock++;
                PCChosePaper++;
                result.Content = computer + wint;
                scorepc++;

                //PlayerChoice Rock
                colorred();
                playerchoice.Content = imga;


                //PcChoice Paper
                colorgreen();
                pcchoice.Content = imgb;
            }
            else if (PlayerChose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                PlayerChoseRock++;
                PCChoseScissors++;
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Rock
                colorgreen();
                playerchoice.Content = imga;


                //PcChoice Scissors
                colorred();
                pcchoice.Content = imgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                PlayerChosePaper++;
                PCChoseScissors++;
                result.Content = computer + wint;
                scorepc++;

                //PlayerChoice Paper
                colorred();
                playerchoice.Content = imgb;


                //PcChoice Scissors
                colorgreen();
                pcchoice.Content = imgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                PlayerChosePaper++;
                PCChoseRock++;
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Paper
                colorgreen();
                playerchoice.Content = imgb;


                //PcChoice Rock
                colorred();
                pcchoice.Content = imga;
            }
            else if (PlayerChose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                PlayerChoseScissors++;
                PCChoseRock++;
                result.Content = computer + wint;
                scorepc++;

                //PlayerChoice Scissors
                colorred();
                playerchoice.Content = imgc;


                //PcChoice Rock
                colorgreen();
                pcchoice.Content = imga;
            }
            else if (PlayerChose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                PlayerChoseScissors++;
                PCChosePaper++;
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Scissors
                colorgreen();
                playerchoice.Content = imgc;


                //PcChoice Paper
                colorred();
                pcchoice.Content = imgb;
            }

            else if (PlayerChose == "Scissors" && Computer == "Scissors")
            {
                PlayerChoseScissors++;
                PCChoseScissors++;
                result.Content = draw;
                colordraw();

                playerchoice.Content = imgc;
                Image copyImgc = new Image();
                copyImgc.Source = imgc.Source;
                pcchoice.Content = copyImgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                PlayerChosePaper++;
                PCChosePaper++;

                result.Content = draw;
                colordraw();

                playerchoice.Content = imgb;
                Image copyImgb = new Image();
                copyImgb.Source = imgb.Source;
                pcchoice.Content = copyImgb;
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                PlayerChoseRock++;
                PCChoseRock++;
                result.Content = draw;
                colordraw();
                playerchoice.Content = imga;
                Image copyImga = new Image();
                copyImga.Source = imga.Source;
                pcchoice.Content = copyImga;
            }
            setcurrentscore();
            

            if (scoreplayer == 10) //If player wins 10 times, then show msg box
            {
                timer1.Stop();
                scorezero();
                count3.Content = "";
                colorbg();
                empty();
                MsgYesNoPLAYER();
                ResetHistoryChoices();
            }
            else if (scorepc == 10) //If pc wins 10 times, then show msg box
            {
                timer1.Stop();
                scoreplayer = 0;
                scorepc = 0;
                count3.Content = "";
                scorezero();
                empty();
                MsgYesNoPC();
                colorbg();
                ResetHistoryChoices();

            }

        }
        #endregion


        #region Button Clicks
        //Button Clicks, random picker and call for BSS game
        private void PaperClick(object sender, RoutedEventArgs e)
        {

            PlayerChose = "Paper";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton1();
            ResetBorderBrush23();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        private void RockClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Rock";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton2();
            ResetBorderBrushButton13();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        private void ScissorsClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Scissors";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton3();
            ResetBorderBrush12();
            BSS();
            HistoryPlayerChoices();
            HistoryPCChoices();
        }

        private void scorereset(object sender, RoutedEventArgs e) //Resets everything
        {
            counter = 4;
            count3.Content = "";
            scorezero();
            colorbg();
            empty();
            ResetBorderBrush12();
            ResetBorderBrush23();
            ResetBorderBrushButton13();
            ResetHistoryChoices();
        }
        #endregion



    }
}