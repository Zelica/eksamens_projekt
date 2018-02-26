using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    public class Player
    {
        public int Max_Life = 20;
        public int Damage = 2;

        public int Current_Life;

        public int air_resistance = 0;
        public int fire_resistance = 0;
        public int water_resistance = 0;
        public int earth_resitnace = 0;

        public Player()
        {
            Current_Life = Max_Life;
        }

    }
}
