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

namespace OefenExamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {

        private string[,] vragen = new string[,]
        {
            { "100", "In the UK, the abbreviation NHS stands for National what Service?", "Humanity", "Health", "Honour", "Household", "2" },
            { "200", "Which Disney character famously leaves a glass slipper behind at a royal ball?", "Pocahontas", "Sleeping Beauty", "Cinderella", "Elsa", "3" },
            { "300", "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?", "Hangar", "Terminal", "Concourse", "Carousel", "4" },
            { "500", "Which of these brands was chiefly associated with the manufacture of household locks?" , "Phillips", "Flymo", "Chubb", "Ronseal", "3" },
            { "1000", "The hammer and sickle is one of the most recognisable symbols of which political ideology?", "Republicanism", "Communism", "Conservatism", "Liberalism", "2" },
            { "2000", "Which toys have been marketed with the phrase 'robots in disguise'?", "Bratz Dolls", "Sylvanian Families", "Hatchimals", "Transformers" , "4" },
            { "4000", "What does the word loquacious mean?", "Angry", "Chatty", "Beautiful", "Shy", "2" },
            { "8000", "Obstetrics is a branch of medicine particularly concerned with what?", "Childbirth", "Broken bones", "Heart conditions", "Old age", "1" },
            { "16000", "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?", "Bow-tie, braces and tweed jacket", "Wide-brimmed hat and extra long scarf", "Pinstripe suit and trainers", "Cape, velvet jacket and frilly shirt", "2" },
            { "32000", "Which of these religious observances lasts for the shortest period of time during the calendar year?", "Ramadan", "Diwali", "Lent", "Hanukkah", "2" },
            { "64000", "At the closest point, which island group is only 50 miles south-east of the coast of Florida?", "Bahamas", "US Virgin Islands", "Turks and Caicos Islands", "Bermuda", "1"},
            { "125000", "Construction of which of these famous landmarks was completed first?" , "Empire State Building", "Royal Albert Hall", "Eiffel Tower", "Big Ben Clock Tower", "4" },
            { "250000", "Which of these cetaceans is classified as a 'toothed whale'?", "Gray whale", "Minke whale", "Sperm whale", "Humpback whale", "3" },
            { "500000", "Who is the only British politician to have held all four 'Great Offices of State' at some point during their career?" , "David Lloyd George", "Harold Wilson", "James Callaghan", "John Major", "3" },
            { "1 million", "In 1718, which pirate died in battle off the coast of what is now North Carolina?" , "Calico Jack", "Blackbeard", "Bartholomew Roberts", "Captain Kidd", "2" }
        };

        private const int max_vragen = 15;
        private DispatcherTimer timer = new DispatcherTimer();
        private bool withDay;
        private List<int> indexes = new List<int>();
        private bool isVerloren;
        private int som = 0;

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            this.TijdTextBlock.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";

            OptieA.Content = vragen[0, 2];
            OptieB.Content = vragen[0, 3];
            OptieC.Content = vragen[0, 4];
            OptieD.Content = vragen[0, 5];

            VraagTextBox.Text = vragen[0,1];

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (!withDay)
                this.TijdTextBlock.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
            else
                this.TijdTextBlock.Text = $"{DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy")}";
        }

        private void combobox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (combobox1.SelectedIndex == 0)
            {
                withDay = false;
                timer.Start();
                this.TijdTextBlock.Text = $"{DateTime.Now.ToString("HH:mm:ss")}";
            }
            else if (combobox1.SelectedIndex == 1)
            {
                withDay = false;
                timer.Stop();
                this.TijdTextBlock.Text = $"{DateTime.Now.ToString("dd/MM/yyyy")}";
            }
            else if (combobox1.SelectedIndex == 2)
            {
                withDay = true;
                timer.Start();
                this.TijdTextBlock.Text = $"{DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy")}";
            }
        }

        private void FinalAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (!isVerloren)
            {
                Random rand = new Random();
                int number = rand.Next(1, 15);

                for (int i = 0; i < max_vragen; i++)
                {
                    if (vragen[i, 1].Equals(VraagTextBox.Text))
                    {
                        som += int.Parse(vragen[i, 0]);
                        indexes.Add(i);
                        if (OptieA.IsChecked == true)
                        {
                            if (int.Parse(vragen[i, 6]).Equals(OptieA.Tag))
                            {
                                //optie A was Juist
                            }
                            else
                            {
                                isVerloren = true;
                            }
                        }
                        else if (OptieB.IsChecked == true)
                        {
                            if (int.Parse(vragen[i, 6]).Equals(OptieB.Tag))
                            {
                                //optie B was Juist
                            }
                            else
                            {
                                isVerloren = true;
                            }
                        }
                        else if (OptieC.IsChecked == true)
                        {
                            if (int.Parse(vragen[i, 6]).Equals(OptieC.Tag))
                            {
                                //optie C was Juist
                            }
                            else
                            {
                                isVerloren = true;
                            }
                        }
                        else if (OptieD.IsChecked == true)
                        {
                            if (int.Parse(vragen[i, 6]).Equals(OptieD.Tag))
                            {
                                //optie D was Juist
                            }
                            else
                            {
                                isVerloren = true;
                            }
                        }
                    }
                }

                for (int i = 0; i <= number; i++)
                {
                    if (!indexes.Contains(i))
                    {
                        VraagTextBox.Text = vragen[number, 1];
                        OptieA.Content = vragen[i, 2];
                        OptieB.Content = vragen[i, 3];
                        OptieC.Content = vragen[i, 4];
                        OptieD.Content = vragen[i, 5];
                    }
                }
            }else
            {
                //verloren
            }
        }
    }
}
