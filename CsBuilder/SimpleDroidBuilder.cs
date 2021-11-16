using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder
{
    public class SimpleDroidBuilder : DroidBuilder
    {
        public override Laser BuildLaser()
        {
            return new BlueLaser();
        }

        public override List<Wheel> BuildWheels()
        {
            List<Wheel> wheels = new List<Wheel>();
            wheels.Add(new ThinWheel());
            wheels.Add(new ThickWheel());
            wheels.Add(new ThickWheel());
            return wheels;
        }

        public override List<Wing> BuildWings()
        {
            List<Wing> wings = new List<Wing>();
            wings.Add(new SilverWing());
            wings.Add(new SilverWing());
            wings.Add(new SilverWing());
            wings.Add(new SilverWing());
            return wings;
        }
    }
}
