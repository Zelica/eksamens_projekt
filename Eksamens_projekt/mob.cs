﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    //Dette er classen Mob. Der nedarves fra denne her til Slime og Undead
    class Mob
    {
        public float MaxLife;
        public float Damage;

        public float CurrentLife;
        public int Score;

        public float AirResistance = 0;
        public float FireResistance = 0;
        public float WaterResistance = 0;
        public float EarthResistance = 0;
    }
}
