using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
    internal class Plane : Vehicle
    {
        public int _wingspan { get;}

        public int _LoadCapacity { get;}

        public int _weight { get;}


        public Plane(string RegNo, int Effect, int wingspan, int loadCapacity, int weight)
            : base(RegNo, Effect)
        {
            _wingspan = wingspan;
            _LoadCapacity = loadCapacity;
            _weight = weight;
        }

        public override void PrintInformation()
        {
            Console.WriteLine("[fly]");
            base.PrintInformation();
            Console.WriteLine($"wingspan: {_wingspan}");
            Console.WriteLine($"LoadCapacity: {_LoadCapacity}");
            Console.WriteLine($"Weight: {_weight}");
        }

        public override void Run()
        {
            Console.WriteLine("Flyet flyr...");  
       
        }
    }
}
