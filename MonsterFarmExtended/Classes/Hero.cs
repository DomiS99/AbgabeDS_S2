using MonsterFarmExtended.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class Hero : Creatures, IFightSystem
    {
        public string Name { get; set; }
        public double Damage { get; set; }
        public List<Item> Inventory { get; set; }
        public Level Level { get; set; }
        public Hero (string name): base(100)
        {
            this.Name = name;
            this.Damage = 20;

        }

        public void AbsorbDamage(Enemy target)
        {
            this.Healthpoints = this.Healthpoints - target.Damage;
        }

        public void Attack(Enemy target)
        {
            target.Healthpoints = target.Healthpoints - this.Damage;
        }
        public Level GetLevel(Hero hero)
        {
            this.Level = new Level(hero);
            Hero UpdatedStats = StatUpdate(hero);
            return Level;
        }

        public Hero StatUpdate(Hero hero)
        {
            hero.Damage = hero.Damage * hero.Level.Multiplicator;
            hero.Healthpoints = hero.Healthpoints * hero.Level.Multiplicator;
            return hero;
        }
    }
}
