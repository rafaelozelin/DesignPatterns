using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Components
{
    class Engine
    {
        public Engine(int power)
        {
            Power = power;
        }

        public int Power { get; set; }
    }
}
