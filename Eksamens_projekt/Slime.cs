using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    //Slime classen ned arver fra Mob classen.
    class Slime : Mob
    {
        public Slime()
        {
            //Dette er de ting som er anderledes fra Mob classen
            Damage = 1;
            MaxLife = 10;

            Score = 10;

            CurrentLife = MaxLife;
        }
    }

    //Dette er en subclass af Slime som er en subclass af Mob
    class BossSlime : Slime
    {
        public BossSlime()
        {
            MaxLife = 20;
            CurrentLife = MaxLife;
        }
    }

    //Dette er en subclass af Slime som er en subclass af Mob
    class FireSlime : Slime
    {
        public FireSlime()
        {
            FireResistance = 1;
            WaterResistance = -1;
        }
    }

    //Dette er en subclass af Slime som er en subclass af Mob
    class WaterSlime : Slime
    {
        public WaterSlime()
        {
            WaterResistance = 1;
            FireResistance = -1;
        }
    }

    //Dette er en subclass af Slime som er en subclass af Mob
    class AirSlime : Slime
    {
        public AirSlime()
        {
            AirResistance = 1;
            EarthResistance = -1;
        }
    }

    //Dette er en subclass af Slime som er en subclass af Mob
    class EarthSlime : Slime
    {
        public EarthSlime()
        {
            EarthResistance = 1;
            AirResistance = -1;
        }
    }
}
