using System;

namespace ConsoleApp9
{
    public class Character
    {
        public string name { get; set; }
        public int health { get; set; }
        public int damage { get; set; }
        public bool IsDead
        {
            get { return this.health <= 0; }
        }

        public virtual void MakeTurn(Character defendingCharacter)
        {
            throw new NotImplementedException();
        }

        public void Attack(Character defendingCharacter)
        {
            defendingCharacter.health -= damage;
            Console.WriteLine($"{defendingCharacter.name} now has: {defendingCharacter.health}hp");
            if (defendingCharacter.health <= 0)
            {
                defendingCharacter = null;
            }
        }
    }
    public class Creature : Character
    {
    }
    public class Player : Character
    {
        public int healthPack = 1;

        public override void MakeTurn(Character defendingCharacter)
        {
            while (defendingCharacter.health >= 0)
            {
                Console.WriteLine("Do you want to ");
                Console.WriteLine("1> Attack");
                Console.WriteLine("2> Heal");
                Console.Write("Please enter an integer: ");
                string input = Console.ReadLine();
                int answer;
                bool success = int.TryParse(input, out answer);
                while (!success)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid Input. Try again...");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Please enter an integer: ");
                    input = Console.ReadLine();
                    success = int.TryParse(input, out answer);
                }
                switch (answer)
                {
                    case 1:
                        Attack(defendingCharacter);
                        break;
                    case 2:
                        Heal();
                        break;

                }
            }
        }
        public void Heal()
        {
            int min = 1;
            int max = 11;

            Random random = new Random();
            int number = random.Next(min, max);

            if (number == 1)
            {
                Console.WriteLine($"it seems the health pack was empty");
            }
            else if (healthPack > 0)
            {
                Console.WriteLine($"You gained 5hp");
                health += 5;
                healthPack--;
                if (health > 10)
                {
                    health = 10;
                    Console.WriteLine($"You now have {health}hp");
                }
                else
                {
                    Console.WriteLine($"You now have {health}hp");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            player.health = 10;
            player.damage = 2;

            while (player.health >= 0)
            {
                RandomRoom();
            }
        }
        public static int GetIntegerInput()
        {
            Console.Write("Please enter an integer: ");
            string input = Console.ReadLine();
            int inputValue;
            bool success = int.TryParse(input, out inputValue);
            while (!success)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Invalid Input. Try again...");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Please enter an integer: ");
                input = Console.ReadLine();
                success = int.TryParse(input, out inputValue);
            }
            return inputValue;
        }
        public static void RandomRoom()
        {
            int min = 1;
            int max = 106;

            Random random = new Random();
            int number = random.Next(min, max);

            if (number <= 30)//30% chance
            {
                Hallway();
            }
            else if (number <= 60)//30% chance
            {
                ThreeWay();
            }
            else if (number <= 90)//30% chance
            {
                FourWay();
            }
            else if (number <= 95)//5% chance
            {
                Treasure();
            }
            else if (number <= 100)//5% chance
            {
                FakeTreasure();
            }
            else if (number <= 105)
            {
                Deadend();
            }
            RandomEvent();
        }
        public static void RandomEvent()
        {
            int min = 1;
            int max = 3;

            Random random = new Random();
            int number = random.Next(min, max);
            switch (number)

            {
                case 1:
                    RandomRoom();
                    break;
                case 2:
                    int min1 = 1;
                    int max1 = 10;

                    Random random1 = new Random();
                    int number1 = random.Next(min1, max1);

                    Random random2 = new Random();
                    int number2 = random.Next(min1, max1);

                    var enemy = new Creature();
                    enemy.health = number1;
                    enemy.damage = number2;

                    player.MakeTurn(enemy);
                    break;
            }
        }
        public static void Hallway()
        {
            Console.WriteLine("You come accross a hallway");
            Console.WriteLine("You have nowhere to go but forward");
        }
        public static void ThreeWay()
        {
            Console.WriteLine("You come accross a three way intersection");
            Console.WriteLine("Do you want to");
            Console.WriteLine("1> Run Left");
            Console.WriteLine("2> Run Right");
            int answer = GetIntegerInput();
        }
        public static void FourWay()
        {
            Console.WriteLine("You come accross a four way intersection");
            Console.WriteLine("Do you want to");
            Console.WriteLine("1> Go Forward");
            Console.WriteLine("2> Run Left");
            Console.WriteLine("3> Run Right");
            int answer = GetIntegerInput();
        }
        public static void Treasure()
        {
            Console.WriteLine("You come accross a glowing chest that surely holds secrets");
            Console.WriteLine("Do you want to");
            Console.WriteLine("1> open the chest");
            Console.WriteLine("2> leave");
            int answer = GetIntegerInput();
            switch (answer)
            {
                case 1:
                    Console.WriteLine("You find a powerful sword, increasing your damage by two");
                    //increase player damage by 2
                    break;

                case 2:
                    RandomRoom();
                    break;

            }
        }
        public static void FakeTreasure()
        {
            Console.WriteLine("You come accross a glowing chest that surely holds secrets");
            Console.WriteLine("Do you want to");
            Console.WriteLine("1> open the chest");
            Console.WriteLine("2> leave");
            int answer = GetIntegerInput();
            switch (answer)
            {
                case 1:
                    //force the player to fight a mimic lol
                    break;

                case 2:
                    RandomRoom();
                    break;

            }
        }
        public static void Shop()
        {

        }
        public static void Deadend()
        {
            Console.WriteLine("You come accross a deadend");
            Console.WriteLine("You have nowhere to go");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}