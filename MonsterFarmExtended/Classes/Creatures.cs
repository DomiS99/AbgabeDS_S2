using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Classes
{
    public abstract class Creatures
    {
        public double Healthpoints { get; set; }

        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public int XP { get; set; }


        public Creatures(double hp)
        {
            this.Healthpoints = hp;
            Random r = new Random();
            this.Age = r.Next(20, 40);
            this.IsAlive = true;
            this.XP = 0;

        }
        public void Die()
        {
            this.Healthpoints = 0;
        }

        public void GettingOlder()
        {
            this.Age = this.Age + 1;
        }




    }
}
