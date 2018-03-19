using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Undead : Mob
    {

        protected Undead()
        {
            Max_Life = 25;
            Damage = 2;

            Score = 20;

            Current_Life = Max_Life;
        }
    }

    class Armored_skeleton : Undead //boss
    {
        public Armored_skeleton()
        {
            Max_Life = 40;
            Current_Life = Max_Life;

            water_resistance = -1;
            fire_resistance = 1;
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

    class Vampire : Undead
    {
        public Vampire()
        {
            earth_resistance = -1;
            fire_resistance = -1;
            water_resistance = 1;
            air_resistance = 1;
        }
    }

    class Ghost : Undead
    {
        public Ghost()
        {
            earth_resistance = -1;
            fire_resistance = 1;
            water_resistance = 1;
            air_resistance = -1;
        }
    }

    class Zombie : Undead
    {
        public Zombie()
        {
            Max_Life = 30;
            Current_Life = Max_Life;

            fire_resistance = -1;
            earth_resistance = 1;
        }
    }
}
 

