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
using System.Windows.Threading;


namespace BSS2
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

        //Ints
        private int scoreplayer = 0;
        private int scorepc = 0;
        private int counter = 3;

        //Bools
        private bool isClicked;

        //Random
        Random random = new Random();
        int RandomType = 0;


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

        private DispatcherTimer timer1;
        private void timer2()//Counter startup
        {
            timer1 = new DispatcherTimer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 1);
            timer1.Start();

            if (counter <=3)
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

        private void colorbg()
        {
            var bc = new BrushConverter(); //new brush

            playerchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
            pcchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
        }

        private void colordraw()
        {
            var bc = new BrushConverter(); //new brush

            playerchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
            pcchoice.Background = (Brush)bc.ConvertFrom("#b8b8b8");
        }

        private void colorred()
        {
            var bc = new BrushConverter();
            playerchoice.Background = (Brush)bc.ConvertFrom("#c22a25");

        }

        private void colorgreen()
        {
            var bc = new BrushConverter();
            pcchoice.Background = (Brush)bc.ConvertFrom("#36cc23");
        }

        private void empty() //clears choice of player and pc
        {
            playerchoice.Content = "";
            pcchoice.Content = "";
            colorbg();
        }

        private void setcurrentscore() //sets the score of player and pc
        {
            scoreplayer1.Content = ($"SPELER {scoreplayer}"); 
            scorepc1.Content = ($"COMPUTER {scorepc}");
        }

        private void scorezero() //sets the score of player and pc to zero
        {
            scoreplayer1.Content = ($"SPELER {0}");
            scorepc1.Content = ($"COMPUTER {0}");
        }


        private void MsgYesNoPLAYER() //Show msgbox content // Questions to continue to play or not
        {
            MessageBoxResult answer = MessageBox.Show("Would you like to play again?", "Congratulations, You Win", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                scorezero();
                BSS();
            }
            else if (answer == MessageBoxResult.No)
            {
                System.Environment.Exit(0);
            }
        }
        private void MsgYesNoPC() //Show msgbox content // Questions to continue to play or not
        {
            MessageBoxResult answer = MessageBox.Show("Would you like to play again?", "Unfortunately, the computer wins", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.No)
            {
                System.Environment.Exit(0);
            }
        }

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
                button2.BorderBrush = Brushes.Red;
            }
        }

        void ChangeBorderBrushButton3()
        {
            if (button3.BorderBrush == Brushes.Gray)
            {
                button3.BorderBrush = Brushes.Red;
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

        private void BSS() // The Rock Paper Scissors-game
        {
            

            if (isClicked = true)
            {
                timer1.Stop();
                count3.Content = "";
            }



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
                result.Content = draw;
                colordraw();

                playerchoice.Content = imgc;
                Image copyImgc = new Image();
                copyImgc.Source = imgc.Source;
                pcchoice.Content = copyImgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                result.Content = draw;
                colordraw();

                playerchoice.Content = imgb;
                Image copyImgb = new Image();
                copyImgb.Source = imgb.Source;
                pcchoice.Content = copyImgb;
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                result.Content = draw;
                colordraw();
                playerchoice.Content = imga;
                Image copyImga = new Image();
                copyImga.Source = imga.Source;
                pcchoice.Content = copyImga;
            }
            setcurrentscore();


            var bc = new BrushConverter(); //new brush

            if (scoreplayer == 10 ) //If player wins 10 times, then show msg box
            {
                timer1.Stop();
                scorezero();
                count3.Content = "";
                colorbg();
                empty();
                MsgYesNoPLAYER();


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
            }

        }

        //Button Clicks, random picker and call for BSS game

        private void PaperClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Paper";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton1();
            ResetBorderBrush23();
            BSS();
        }

        private void RockClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Rock";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton2();
            ResetBorderBrushButton13();
            BSS();
        }

        private void ScissorsClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Scissors";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            ChangeBorderBrushButton3();
            ResetBorderBrush12();
            BSS();
        }

        private void scorereset(object sender, RoutedEventArgs e) //Resets everything
        {
            var bc = new BrushConverter(); //new brush
            timer1.Stop();
            count3.Content = "";
            scorezero();
            colorbg();
            empty();
        }
    }
}