using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder
{
    public abstract class DroidBuilder
    {
        public abstract Laser BuildLaser();
        public abstract List<Wheel> BuildWheels();
        public abstract List<Wing> BuildWings();
        protected string name;
        public Droid GetDroid()
        {
            Laser laser = BuildLaser();
            List<Wheel> wheels = BuildWheels();
            List<Wing> wings = BuildWings();

            return new Droid(laser,wheels,wings,name);
        }
    }
}
