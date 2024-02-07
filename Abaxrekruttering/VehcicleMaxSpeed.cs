using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    abstract class VehcicleMaxSpeed : Vehicle
    {
        public int _Maxspeed { get;}

        public string _MaxSpeedUnit { get;}



        protected VehcicleMaxSpeed(int maxspeed, string RegNumber, int effect, string Maxspeed = "km/t") : base(RegNumber, effect) 
        {
           _Maxspeed = maxspeed;
           _MaxSpeedUnit = Maxspeed;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Maksfart: {_Maxspeed}, {_MaxSpeedUnit}");
        }
    }
}
