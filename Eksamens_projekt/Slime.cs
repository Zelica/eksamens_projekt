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
            Max_Life = 10;

            Score = 10;

            Current_Life = Max_Life;
        }
    }

    class Boss_Slime : Slime
    {
        public Boss_Slime()
        {
            Max_Life = 20;
            Current_Life = Max_Life;
        }
    }

    class Fire_Slime : Slime
    {
        public Fire_Slime()
        {
            fire_resistance = 1;
            water_resistance = -1;
        }
    }

    class Water_Slime : Slime
    {
        public Water_Slime()
        {
            water_resistance = 1;
            fire_resistance = -1;
        }
    }

    class Air_Slime : Slime
    {
        public Air_Slime()
        {
            air_resistance = 1;
            earth_resistance = -1;
        }
    }

    class Earth_Slime : Slime
    {
        public Earth_Slime()
        {
            earth_resistance = 1;
            air_resistance = -1;
        }
    }
}
