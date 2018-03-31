using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    public class Player
    {
        public float MaxLife = 20;
        public float Damage = 2;

        public float CurrentLife;

        public float AirResistance = 0;
        public float FireResistance = 0;
        public float WaterResistance = 0;
        public float EarthResistance = 0;

        public Player()
        {
            CurrentLife = MaxLife;
        }

    }
}
