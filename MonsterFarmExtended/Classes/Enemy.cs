using MonsterFarmExtended.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class Enemy : Creatures, IGiveXP
    {
        public int EnemyXP;
        public double Damage { get; set; }
        public Enemy () : base(80)
        {
            this.EnemyXP = 50;
            this.Damage = 5;
        }

        public void GetXP(Hero hero)
        {
            hero.XP = hero.XP + this.EnemyXP;
        }
    }
}
