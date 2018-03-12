using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Undead
    {
        protected float Max_Life = 25;
        protected float Damage = 2;

        protected float Current_Life;

        protected float air_resistance = 0;
        protected float fire_resistance = 0;
        protected float water_resistance = 0;
        protected float earth_resistance = 0;

        protected Undead()
        {
            Current_Life = Max_Life;
        }
    }

    class Zombie : Undead
    {
        public Zombie()
        {
            Max_Life = 40;
            fire_resistance = -1;
            earth_resistance = 1;
        }
    }

    class Skeleton : Undead
    {
        public Skeleton()
        {
            water_resistance = -1;
            fire_resistance = 1;
        }
    }
}
 

