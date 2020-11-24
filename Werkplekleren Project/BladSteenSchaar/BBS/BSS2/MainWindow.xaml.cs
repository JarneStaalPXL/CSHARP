﻿using System;
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

            var ab = new BrushConverter(); //new brush


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
                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = imga;


                //PcChoice Paper
                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = imgb;
            }
            else if (PlayerChose == "Rock" && Computer == "Scissors") // Player: Rock, Computer: Scissors = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Rock
                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = imga;


                //PcChoice Scissors
                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = imgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Scissors") // Player: Paper, Computer: Scissors = Computer wins
            {
                result.Content = computer + wint;
                scorepc++;

                //PlayerChoice Paper
                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = imgb;


                //PcChoice Scissors
                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = imgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Rock") // Player: Paper, Computer: Rock = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Paper
                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = imgb;


                //PcChoice Rock
                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = imga;
            }
            else if (PlayerChose == "Scissors" && Computer == "Rock") // Player: Scissors, Computer: Rock = Computer wins
            {
                result.Content = computer + wint;
                scorepc++;

                //PlayerChoice Scissors
                playerchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                playerchoice.Content = imgc;


                //PcChoice Rock
                pcchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                pcchoice.Content = imga;
            }
            else if (PlayerChose == "Scissors" && Computer == "Paper") // Player: Scissors, Computer: Paper = Player wins
            {
                result.Content = player + wint;
                scoreplayer++;

                //PlayerChoice Scissors
                playerchoice.Background = (Brush)ab.ConvertFrom("#36cc23");
                playerchoice.Content = imgc;


                //PcChoice Paper
                pcchoice.Background = (Brush)ab.ConvertFrom("#c22a25");
                pcchoice.Content = imgb;
            }

            else if (PlayerChose == "Scissors" && Computer == "Scissors")
            {
                result.Content = draw;
                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = imgc;
                Image copyImgc = new Image();
                copyImgc.Source = imgc.Source;
                pcchoice.Content = copyImgc;
            }
            else if (PlayerChose == "Paper" && Computer == "Paper")
            {
                result.Content = draw;
                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = imgb;
                Image copyImgb = new Image();
                copyImgb.Source = imgb.Source;
                pcchoice.Content = copyImgb;
            }
            else if (PlayerChose == "Rock" && Computer == "Rock")
            {
                result.Content = draw;


                playerchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");
                pcchoice.Background = (Brush)ab.ConvertFrom("#b8b8b8");

                playerchoice.Content = imga;
                Image copyImga = new Image();
                copyImga.Source = imga.Source;
                pcchoice.Content = copyImga;
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
            var bc = new BrushConverter(); //new brush

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