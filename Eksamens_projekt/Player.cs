using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eksamens_projekt
{
    //Dette er player classen den indeholder alt informationen vedrørende playeren
    public class Player
    {
        public float MaxLife = 20;
        public float Damage = 2;

        public float CurrentLife;

        //En lidt ubrugt del af Player classen.
        //Det ville tages i brug hvis spillen kunne købe items og monstrene kunne burge elementar angreb
        public float AirResistance = 0;
        public float FireResistance = 0;
        public float WaterResistance = 0;
        public float EarthResistance = 0;

        public Player()
        {
            //Dette skaber en værdi CurrentLife som er den samme som MaxLife dette gør det nemmere at genstarte.
            CurrentLife = MaxLife;
        }

    }
}
