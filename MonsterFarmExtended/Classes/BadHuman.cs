using MonsterFarmExtended.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class BadHuman : Enemy, IGiveXP
    {
        public BadHuman() : base()
        {
            this.Healthpoints = this.Healthpoints - 20;
            this.Damage = this.Damage + 5;
        }

        public void GetXP(Hero hero)
        {
            hero.XP = hero.XP + this.EnemyXP;
        }
    }
}
