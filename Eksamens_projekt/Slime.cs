using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Slime
    {
        protected int life = 10;
        protected int damarge = 1;

        protected int air_resistance = 0;
        protected int fire_resistance = 0;
        protected int water_resistance = 0;
        protected int earth_resistance = 0;
    }

    class Fire : Slime
    {
        Fire()
        {
            fire_resistance = 1;
            water_resistance = -1;
        }
    }

    class Water : Slime
    {
        Water()
        {
            water_resistance = 1;
            fire_resistance = -1;
        }
    }

    class Air : Slime
    {
        Air()
        {
            air_resistance = 1;
            earth_resistance = -1;
        }
    }

    class Earth : Slime
    {
        Earth()
        {
            earth_resistance = 1;
            air_resistance = -1;
        }
    }
}
