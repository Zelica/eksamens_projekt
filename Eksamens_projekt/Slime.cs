using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Slime : Mob
    {

        public Slime()
        {
            Damage = 1;
            MaxLife = 10;

            Score = 10;

            CurrentLife = MaxLife;
        }
    }

    class BossSlime : Slime
    {
        public BossSlime()
        {
            MaxLife = 20;
            CurrentLife = MaxLife;
        }
    }

    class FireSlime : Slime
    {
        public FireSlime()
        {
            FireResistance = 1;
            WaterResistance = -1;
        }
    }

    class WaterSlime : Slime
    {
        public WaterSlime()
        {
            WaterResistance = 1;
            FireResistance = -1;
        }
    }

    class AirSlime : Slime
    {
        public AirSlime()
        {
            AirResistance = 1;
            EarthResistance = -1;
        }
    }

    class EarthSlime : Slime
    {
        public EarthSlime()
        {
            EarthResistance = 1;
            AirResistance = -1;
        }
    }
}
