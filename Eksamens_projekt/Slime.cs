using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Slime
    {
        public int Current_Life = 10;
        public int Damage = 1;
        public int Level = 1;

        public int Max_Life;

        public int air_resistance = 0;
        public int fire_resistance = 0;
        public int water_resistance = 0;
        public int earth_resistance = 0;

        public Slime()
        {
            Max_Life = Current_Life;
        }
    }

    class Fire : Slime
    {
        public Fire()
        {
            fire_resistance = 1;
            water_resistance = -1;
        }
    }

    class Water : Slime
    {
        public Water()
        {
            water_resistance = 1;
            fire_resistance = -1;
        }
    }

    class Air : Slime
    {
        public Air()
        {
            air_resistance = 1;
            earth_resistance = -1;
        }
    }

    class Earth : Slime
    {
        public Earth()
        {
            earth_resistance = 1;
            air_resistance = -1;
        }
    }
}
