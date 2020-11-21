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
        private string msg = "   Result: ";
        private string computer = "Computer";
        private string player = "Player";
        private string draw = "Draw";

        public MainWindow()
        {
            InitializeComponent();
        }
        public void BBS() // The Rock Paper Scissors-game
        {
            scoreplayer1.Content = ($"PLAYER {scoreplayer}"); //old score
            scorepc1.Content = ($"PC: {scorepc}"); //old score

            if (PlayerChose == "Rock" && Computer == "Paper") // Player: Rock, Computer: paper = computer wins
            {
                MessageBox.Show(msg + computer);
                scorepc++;
            }
            else if (PlayerChose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                MessageBox.Show(msg + player);
                scoreplayer++;
            }
            else if (PlayerChose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                MessageBox.Show(msg + computer);
                scorepc++;
            }
            else if (PlayerChose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                MessageBox.Show(msg + player);
                scoreplayer++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                MessageBox.Show(msg + computer);
                scorepc++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                MessageBox.Show(msg + player);
                scoreplayer++;
            }
            else if (PlayerChose == "Scissors" && Computer == "Scissor")
            {
                MessageBox.Show(msg + draw);

            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                MessageBox.Show(msg + draw);
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                MessageBox.Show(msg + draw);
            }

            scoreplayer1.Content = ($"PLAYER {scoreplayer}"); //new score
            scorepc1.Content = ($"PC: {scorepc}"); //new score 

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