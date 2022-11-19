using MonsterFarmExtended.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class WildAnimal : Enemy, IGiveXP
    {
        public bool IsBoss { get; set; }
        public WildAnimal(bool isboss) :base()
        {
            this.Healthpoints = this.Healthpoints -20;
            this.Damage = this.Damage + 5;
            this.EnemyXP = this.EnemyXP - 5;
            this.IsBoss = isboss;

            if (this.IsBoss = true)
            {
                this.Healthpoints = this.Healthpoints * 2;
                this.Damage = this.Damage * 2;
                this.EnemyXP = this.EnemyXP * 3;
            }
        }

        public void GetXP(Hero hero)
        {
            hero.XP = hero.XP + this.EnemyXP;
        }
    }
}
