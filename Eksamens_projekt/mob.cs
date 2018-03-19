using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    class Mob
    {
        public float Max_Life;
        public float Damage;

        public float Current_Life;
        public int Score;

        public float air_resistance = 0;
        public float fire_resistance = 0;
        public float water_resistance = 0;
        public float earth_resistance = 0;

        protected Mob()
        {
            Current_Life = Max_Life;
        }
    }
}
