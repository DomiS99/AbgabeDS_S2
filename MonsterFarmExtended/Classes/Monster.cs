using MonsterFarmExtended.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class Monster : Enemy, IGiveXP
    {
        public bool IsBoss { get; set; }
        public Monster(bool isboss) : base()
        {
            this.Healthpoints = this.Healthpoints + 40;
            this.Damage = this.Damage - 2;
            this.EnemyXP = this.EnemyXP + 10;
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
