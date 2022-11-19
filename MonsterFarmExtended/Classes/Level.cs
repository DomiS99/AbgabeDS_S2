using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public class Level
    {
        public int LevelInt { get; set; }

        public Level(Hero hero)
        {
            LevelCounter(hero);
        }
        public Level LevelCounter(Hero hero)
        {
            if (hero.XP <= 500)
            {
                Level Counter = hero.Level;
                this.LevelInt = 1;
                return Counter;
            }
            else if (hero.XP > 500 || hero.XP <= 1500)
            {
                Level Counter = hero.Level;
                this.LevelInt = 2;
                return Counter;
            }
            else if (hero.XP > 1500 || hero.XP <= 3000)
            {
                Level Counter = hero.Level;
                this.LevelInt = 3;
                return Counter;
            }
            else if (hero.XP > 3000 || hero.XP <= 6000)
            {
                Level Counter = hero.Level;
                this.LevelInt = 4;
                return Counter;
            }
            else if (hero.XP > 6000 || hero.XP <= 10000)
            {
                Level Counter = hero.Level;
                this.LevelInt = 5;
                return Counter;
            }
            else
            {
                Level Counter = hero.Level;
                this.LevelInt = 69;
                return Counter;
            }  

        }
    }
}
