﻿

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
            Console.WriteLine($"Do you want to reload the last game (r) or create a new hero (n){Environment.NewLine}" +
                $"Attention the last hero will be deleted if you create a new one!");
            string RoN = Console.ReadLine();
            if (RoN == "r")
            {
                Hero Player = SaveAndLoadHero.Load();
                Console.ReadLine();
                SaveAndLoadHero.Save(Player.Name, Player.Age, Player.Damage, Player.Healthpoints, Player.XP);
            }
            else if (RoN == "n")
            {
                Hero Player = CreateHero();
                Console.ReadLine();
                SaveAndLoadHero.Save(Player.Name,Player.Age,Player.Damage,Player.Healthpoints,Player.XP);
            }
            else
            { Console.WriteLine("Wrong entry!"); }
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
            string name = Console.ReadLine();
            Hero NewHero = new Hero(name);
            NewHero.GetLevel(NewHero);
            Console.WriteLine($"Your Hero {NewHero.Name} has been born. {Environment.NewLine}" +
                $"{NewHero.Name} is currently {NewHero.Age} Years old. {Environment.NewLine}Your Hero is currently at full Health which is {NewHero.Healthpoints}{Environment.NewLine}" +
                $"You currently have {NewHero.XP} Experience. Therfor your current Level is {NewHero.Level.LevelInt}");
            return NewHero;

        }
    }
}
