

using MonsterFarmExtended.Classes;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace MonsterFarmExtended
{
    class Program
    {
        static void Main(string[] args)
        {

            Intro();
            Hero Player = Load();
            Console.WriteLine("You have encountered your first Enemy. Its a Monster.");
            Monster monster = CreateMonster();
            Battle(monster, Player);
            Console.WriteLine(Player.XP);
            Console.WriteLine(Player.Damage);
            Console.WriteLine(Player.Healthpoints);
            SaveAndLoadHero.Save(Player.Name,Player.Age,Player.Damage,Player.Healthpoints,Player.XP);
        }

        public static void Intro()
        {
            Console.WriteLine($"Welcome to this small RPG Console Game{Environment.NewLine}" +
            $"You are a young, strong and breave hero hungry for glory.{Environment.NewLine}" +
            $"On your quest to glory you have to overcome some obsticals which now may seem overwhelming. But just stick in there great things have still to come{Environment.NewLine}" +
            $"You have to fight different Enemys like Monsters or Wild Animals. Dispiceable Human beings will try to stop you.{Environment.NewLine}" +
            $"But now you have to go... Oh i almost forgot: Whats your name ?");

        }

        public static Hero CreateHero()
        {
            Console.WriteLine("What's your Name again?");
            string name = Console.ReadLine();
            Hero NewHero = new Hero(name);
            NewHero.GetLevel(NewHero);
            Console.WriteLine($"Your Hero {NewHero.Name} has been born. {Environment.NewLine}" +
                $"{NewHero.Name} is currently {NewHero.Age} Years old. {Environment.NewLine}Your Hero is currently at full Health which is {NewHero.Healthpoints}{Environment.NewLine}" +
                $"You currently have {NewHero.XP} Experience. Therfor your current Level is {NewHero.Level.LevelInt}");
            return NewHero;

        }

        public static Hero Load()
        {

            Console.WriteLine($"Do you want to reload the last game (r)? {Environment.NewLine}" +
            $"Attention the last hero will be deleted if you create a new one!");
            string RoN = Console.ReadLine();
                if (RoN == "r")
                {
                    Hero Player = SaveAndLoadHero.Load();
                    Console.ReadLine();
                    return Player;
                }
                else
                {
                    Hero Player = CreateHero();
                    Console.ReadLine();
                    return Player;
                }
        }

        public static Monster CreateMonster()
        {
            Monster monster = new Monster();
            return monster;
        }

        public static void Battle(Enemy monster, Hero hero)
        {

            Console.WriteLine($"An epic battle begins");
            int roundcounter = 0;
            for (double i = monster.Healthpoints; i > 0; i++)
            {
                if (monster.Healthpoints > 0)
                {
                    roundcounter = roundcounter + 1;
                    Console.WriteLine($"Round: {roundcounter}");
                    hero.Attack(monster);
                    hero.AbsorbDamage(monster);
                    if (monster.Healthpoints < 0)
                    {
                        monster.Healthpoints = 0;
                    }
                    Console.WriteLine($"Stats after Round {roundcounter}: {Environment.NewLine}Hero HP: {hero.Healthpoints} {Environment.NewLine} Monster HP: {monster.Healthpoints}");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"The Monster is Dead");
                    break;
                }
            }
            monster.GetXP(hero);


        }   
    }
}
