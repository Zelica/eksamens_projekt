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
            MaxLife = 25;
            Damage = 2;

            Score = 20;

            CurrentLife = MaxLife;
        }
    }

    class Armored_skeleton : Undead //boss
    {
        public Armored_skeleton()
        {
            MaxLife = 40;
            CurrentLife = MaxLife;

            WaterResistance = -1;
            FireResistance = 1;
        }
    }

    class Skeleton : Undead
    {
        public Skeleton()
        {
            WaterResistance = -1;
            FireResistance = 1;
        }
    }

    class Vampire : Undead
    {
        public Vampire()
        {
            EarthResistance = -1;
            FireResistance = -1;
            WaterResistance = 1;
            AirResistance = 1;
        }
    }

    class Ghost : Undead
    {
        public Ghost()
        {
            EarthResistance = -1;
            FireResistance = 1;
            WaterResistance = 1;
            AirResistance = -1;
        }
    }

    class Zombie : Undead
    {
        public Zombie()
        {
            MaxLife = 30;
            CurrentLife = MaxLife;

            FireResistance = -1;
            EarthResistance = 1;
        }
    }
}
 

