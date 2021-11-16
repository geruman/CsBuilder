using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder
{
    public class AdvancedDroidBuilder : DroidBuilder
    {
        public override Laser BuildLaser()
        {
            return new RedLaser();
        }

        public override List<Wheel> BuildWheels()
        {
            List<Wheel> wheels = new List<Wheel>();
            wheels.Add(new ThickWheel());
            wheels.Add(new ThickWheel());
            wheels.Add(new ThickWheel());
            wheels.Add(new ThickWheel());
            return wheels;
        }

        public override List<Wing> BuildWings()
        {
            List<Wing> wings = new List<Wing>();
            wings.Add(new GoldenWing());
            wings.Add(new GoldenWing());
            wings.Add(new GoldenWing());
            wings.Add(new GoldenWing());
            return wings;
        }
    }
}
