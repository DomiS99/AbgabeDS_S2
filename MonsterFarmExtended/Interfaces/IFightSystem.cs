using MonsterFarmExtended.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterFarmExtended.Interfaces
{
    public interface IFightSystem
    {
        void AbsorbDamage(Enemy target);
        void Attack(Enemy target);
    }
}
