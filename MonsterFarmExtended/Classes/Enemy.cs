using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class Enemy : Creatures
    {
        public int EnemyXP;
        public int Damage { get; set; }
        public Enemy () : base(80)
        {
            this.EnemyXP = 50;
            this.Damage = 5;
        }
    }
}
