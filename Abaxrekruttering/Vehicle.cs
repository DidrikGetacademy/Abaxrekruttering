using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abaxrekruttering
{
   public abstract class Vehicle
    {

        public string _RegNumber { get;} 

        public int _Effect { get; }


        protected Vehicle( string RegNo, int Effect)
        {
            _RegNumber = RegNo;
            _Effect = Effect;
        }

        public abstract void Run();

        public virtual void PrintInformation()
        {
            Console.WriteLine($"Registration-Number: {_RegNumber}");
            Console.WriteLine($"Effect: {_Effect} kw");

        }
    }
}
    