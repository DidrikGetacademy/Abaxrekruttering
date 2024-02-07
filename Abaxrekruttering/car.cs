using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class car : VehcicleMaxSpeed
    {

        public string _color { get; set; }

        public bool _IsLightVehicle { get; set; }
        public car(int maxspeed, string Regnumber, int effect,string color,bool isLightVehicle)
            : base(maxspeed, Regnumber, effect)
        {
            _color = color;
            _IsLightVehicle = isLightVehicle;
        }

        public override void PrintInformation()
        {
     
           Console.WriteLine("[Car]");
           base.PrintInformation();
           Console.WriteLine($"Farge- {_color}");
           if(_IsLightVehicle) Console.WriteLine("- lett kjøretøy");
           Console.WriteLine();
        }


        public override void Run()
        {
            Console.WriteLine("Bil kjører..."); 
        }


      
    }
}
