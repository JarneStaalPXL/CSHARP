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

namespace BBS
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
        private int scoreplayer = 0;
        private int scorepc = 0;
        string computer = "Computer";
        string player = "Speler";
        string draw = "Gelijkspel";
        string wint = " wint";

        //Random
        Random random = new Random();
        int RandomType = 0;

        
        

        public MainWindow()
        {

            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("HH:mm:ss")}";
            },
            this.Dispatcher);
        }
        private void BBS() // The Rock Paper Scissors-game
        {
            scoreplayer1.Content = ($"SPELER {scoreplayer}"); //old score
            scorepc1.Content = ($"COMPUTER {scorepc}"); //old score

            var ab = new BrushConverter();

            if (PlayerChose == "Rock" && Computer == "Paper") // Player: Rock, Computer: paper = computer wins
            {
                result.Content = computer + wint;
                scorepc++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = "Steen";

                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = "Blad";
            }
            else if (PlayerChose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = "Steen";

                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = "Schaar";
            }
            else if (PlayerChose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                result.Content = computer + wint;
                scorepc++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = "Blad";

                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = "Schaar";
            }
            else if (PlayerChose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = "Blad";

                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = "Steen";
            }
            else if (PlayerChose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                result.Content = computer + wint;
                scorepc++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = "Schaar";

                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = "Steen";
            }
            else if (PlayerChose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = "Schaar";

                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = "Blad";
            }

            else if (PlayerChose == "Scissors" && Computer == "Scissor")
            {
                result.Content = draw;
                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = "Schaar";
                pcchoice.Content = "Schaar";
            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                result.Content = draw;
                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = "Blad";
                pcchoice.Content = "Blad";
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                result.Content = draw;
                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = "Steen";
                pcchoice.Content = "Steen";
            }

            scoreplayer1.Content = ($"SPELER {scoreplayer}"); //new score
            scorepc1.Content = ($"COMPUTER {scorepc}"); //new score 

        }
        private void RockClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Rock";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            BBS();
        }

        private void PaperClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Paper";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            BBS();
        }

        private void ScissorsClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Scissors";
            RandomType = random.Next(0, 3);
            Computer = answers[RandomType];
            BBS();
        }

        private void scorereset(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();

            scoreplayer = 0;
            scorepc = 0;
            scoreplayer1.Content = ($"SPELER {scoreplayer}"); //new score
            scorepc1.Content = ($"COMPUTER {scorepc}"); //new score 
            playerchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
            pcchoice.Background = (Brush)bc.ConvertFrom("#2b2b2b");
            playerchoice.Content = "";
            pcchoice.Content = "";
        }
    }
}