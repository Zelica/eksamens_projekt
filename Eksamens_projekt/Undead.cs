using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    //Undead nedarver/er en subclass af Mob
    class Undead : Mob
    {
        //den er protected for at man ikke kan kalde den uden fra classen. Dette gøres for at vi ikke får en "undead" som et monster man kan kæmpe i mod.
        protected Undead()
        {
            MaxLife = 25;
            Damage = 2;

            Score = 20;

            CurrentLife = MaxLife;
        }
    }

    //En specific type af Undead. Endnu en subclass af en subclass
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

    //En specific type af Undead. Endnu en subclass af en subclass
    class Skeleton : Undead
    {
        public Skeleton()
        {
            WaterResistance = -1;
            FireResistance = 1;
        }
    }

    //En specific type af Undead. Endnu en subclass af en subclass
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

    //En specific type af Undead. Endnu en subclass af en subclass
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

    //En specific type af Undead. Endnu en subclass af en subclass
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
 

