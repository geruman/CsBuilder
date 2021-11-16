using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder
{
    public class Droid
    {
        public Droid(Laser laser, List<Wheel> wheels, List<Wing> wings,string name)
        {
            Laser = laser;
            Wheels = wheels;
            Wings = wings;
            Name = name;
        }
        public string Name { get; set; }
        public Laser Laser { get; set; }
        public List<Wheel> Wheels { get; set; }
        public List<Wing> Wings { get; set; }

    }
}
