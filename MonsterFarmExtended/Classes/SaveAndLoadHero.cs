using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime.CompilerServices;

namespace MonsterFarmExtended.Classes
{
    public class SaveAndLoadHero
    {
        public static void Save(string name, int age, double damage, double healthpoints, int xp)
        {
            List<Hero> list = new List<Hero>();
            list.Add(new Hero(name)
            {
                Name = name,
                Age = age,
                Damage = damage,
                Healthpoints = healthpoints,
                XP = xp,


            });

            string json = JsonSerializer.Serialize(list);
            File.WriteAllText(@"D:\TestSaveData\Data.json",json);
        }

        public static Hero Load()
        {
            string text = File.ReadAllText(@"D:\TestSaveData\Data.json");
            Hero Player = JsonSerializer.Deserialize<Hero>(text);
            return Player;
        }
    }
}
