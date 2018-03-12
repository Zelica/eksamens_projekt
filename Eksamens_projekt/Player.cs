using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    public class Player
    {
        public float Max_Life = 20;
        public float Damage = 2;

        public float Current_Life;

        public float air_resistance = 0;
        public float fire_resistance = 0;
        public float water_resistance = 0;
        public float earth_resitnace = 0;

        public Player()
        {
            Current_Life = Max_Life;
        }

    }
}
