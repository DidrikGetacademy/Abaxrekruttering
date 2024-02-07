using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Boat : VehcicleMaxSpeed
    {
        public int _GrossTonnage { get; }

        public Boat(int maxspeed, string RegNumber, int effect, int grossTonnage)
            : base(maxspeed, RegNumber, effect, "Knop")
        {
            _GrossTonnage = grossTonnage;
        }


        public override void PrintInformation()
        {
            Console.WriteLine("[Boat]");
            base.PrintInformation();
            Console.WriteLine($"GrossTonnage: {_GrossTonnage}kg");

        }

        public override void Run()
        {
            Console.WriteLine("kjører båt...");
        }
    }
}
