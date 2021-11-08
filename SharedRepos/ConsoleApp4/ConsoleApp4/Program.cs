using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string heroChosen;
            string heroFightChosen;
            int DamageUser = 0;
            int DamagePC = 0;
            int resultUser = 0;
            int resultPC = 0;
            bool isWinner;
            bool isLoser;

            //Heroes
            Soldier soldier = new Soldier();
            Diva diva = new Diva();
            List<string> arrayHeroes = new List<string> { "Soldier", "Diva" };
            List<string> arrayHeroesLeft = new List<string> { "Soldier", "Diva" };

            //Game
            do
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Choose one of these heroes");
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (var item in arrayHeroes)
                {
                    Console.WriteLine($"- {item} ");
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nType choice here: ");
                Console.ForegroundColor = ConsoleColor.Green;
                heroChosen = Console.ReadLine();

            } while (!arrayHeroes.Contains(heroChosen)); ;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You have chosen ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(heroChosen);

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n\nChoose one of these heroes to fight with");
                Console.ForegroundColor = ConsoleColor.Red;
                arrayHeroesLeft.Remove(heroChosen);
                foreach (var item in arrayHeroesLeft)
                {
                    Console.WriteLine($"- {item} ");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nType choice here: ");
                Console.ForegroundColor = ConsoleColor.Green;
                heroFightChosen = Console.ReadLine();

            } while (!arrayHeroesLeft.Contains(heroFightChosen));

            Console.Clear();

            //Fight
            while (true)
            {

                Console.ForegroundColor = ConsoleColor.White;
                Random rand = new Random();
                Console.Write("Throwing dice for User ");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(".");
                }
                int AttackUserCount = rand.Next(5, 14);


                Console.Write("\nThrowing dice for PC   ");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(200);
                    Console.Write(".");
                }
                int AttackPCCount = rand.Next(5, 14);
                Console.Clear();

                bool isUserSoldier = false;
                if (heroChosen == arrayHeroes[0])
                {
                    isUserSoldier = true;
                    DamageUser = soldier.damage * AttackPCCount;
                }
                else if (heroChosen == arrayHeroes[1])
                {
                    isUserSoldier = false;
                    DamageUser = diva.damage * AttackPCCount;
                }

                if (heroFightChosen == arrayHeroes[0])
                {
                    DamagePC = soldier.damage * AttackPCCount;
                }
                else if (heroFightChosen == arrayHeroes[1])
                {
                    DamagePC = diva.damage * AttackPCCount;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{heroChosen} attacks {heroFightChosen} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{ AttackUserCount} times");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n{heroFightChosen} attacks {heroChosen} ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{AttackPCCount} times");



                if (isUserSoldier == true)
                {
                    resultUser = soldier.Health - DamagePC;
                    resultPC = diva.Health - DamageUser;

                    if (resultUser < 0)
                    {
                        resultUser = 0;
                    }
                    else if (resultPC <0)
                    {
                        resultPC = 0;
                    }

                    Console.WriteLine($"\n\n{arrayHeroes[0]} -> {resultUser}HP");
                    Console.WriteLine($"{arrayHeroes[1]} -> {resultPC}HP");

                    Console.ForegroundColor = ConsoleColor.Green;

                    if (resultUser == 0)
                    {
                        Console.WriteLine("\n" + heroFightChosen +" wins");
                    }
                    else if (resultPC == 0)
                    {
                        Console.WriteLine("\n" + heroChosen + " wins");
                    }
                    else if (resultUser == 0 && resultPC == 0)
                    {
                        Console.WriteLine("\n" + "Draw");
                    }
                }
                else
                {
                    if (resultUser < 0)
                    {
                        resultUser = 0;
                    }
                    else if (resultPC < 0)
                    {
                        resultPC = 0;
                    }
                    resultPC = soldier.Health - DamageUser;
                    resultUser = diva.Health - DamagePC;

                    Console.WriteLine($"\n\n{arrayHeroes[0]} -> {resultPC}HP");
                    Console.WriteLine($"{arrayHeroes[1]} -> {resultUser}HP");

                    if (resultUser == 0)
                    {
                        Console.WriteLine("\n"+heroFightChosen + " wins");
                    }
                    else if (resultPC == 0)
                    {
                        Console.WriteLine("\n" + heroChosen + " wins");
                    }
                    else if (resultUser == 0 && resultPC == 0)
                    {
                        Console.WriteLine("\n" + "Draw");
                    }
                }


                Console.WriteLine("\nNew match? Press enter");
                Console.ReadLine();
            }
        }
    }
}
