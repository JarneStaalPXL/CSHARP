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
        // Variables 
        string Computer;
        string[] answers = { "Rock", "Paper", "Scissors" };
        Random random = new Random();
        int RandomType = 0;
        string PlayerChose;
        private int scoreplayer = 0;
        private int scorepc = 0;
        private string computer = "Computer";
        private string title = "Resultaat";
        private string player = "Speler";
        private string draw = "Gelijkspel";

        public MainWindow()
        {

            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                this.timeLabel.Content = $"{DateTime.Now.ToString("d")}\n{DateTime.Now.ToString("HH:mm:ss")}";
            },
            this.Dispatcher);
        }
        public void BBS() // The Rock Paper Scissors-game
        {
            scoreplayer1.Content = ($"SPELER {scoreplayer}"); //old score
            scorepc1.Content = ($"COMPUTER {scorepc}"); //old score

            if (PlayerChose == "Rock" && Computer == "Paper") // Player: Rock, Computer: paper = computer wins
            {
                MessageBox.Show($"   {computer, title}");
                scorepc++;
            }
            else if (PlayerChose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                MessageBox.Show(player, title);
                scoreplayer++;
            }
            else if (PlayerChose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                MessageBox.Show(computer, title);
                scorepc++;
            }
            else if (PlayerChose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                MessageBox.Show(player, title);
                scoreplayer++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                MessageBox.Show(computer, title);
                scorepc++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                MessageBox.Show(player, title);
                scoreplayer++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Scissor")
            {
                MessageBox.Show(draw);

            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                MessageBox.Show(draw);
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                MessageBox.Show(draw);
            }

            scoreplayer1.Content = ($"SPELER {scoreplayer}"); //new score
            scorepc1.Content = ($"COMPUTER {scorepc}"); //new score 

        }
        private void RockClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Rock";
            RandomType = random.Next(0, 2);
            Computer = answers[RandomType];
            BBS();
        }

        private void PaperClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Paper";
            RandomType = random.Next(0, 2);
            Computer = answers[RandomType];
            BBS();
        }

        private void ScissorsClick(object sender, RoutedEventArgs e)
        {
            PlayerChose = "Scissors";
            RandomType = random.Next(0, 2);
            Computer = answers[RandomType];
            BBS();
        }
    }
}