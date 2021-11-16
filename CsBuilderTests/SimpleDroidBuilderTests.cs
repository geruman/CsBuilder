using Microsoft.VisualStudio.TestTools.UnitTesting;
using CsBuilder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsBuilder.Tests
{
    [TestClass()]
    public class SimpleDroidBuilderTests
    {
        private DroidBuilder builder;
        [TestInitialize()]
        public void Initialize()
        {
            builder = new SimpleDroidBuilder();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            builder = null;
        }
        [TestMethod()]
        public void BuildLaserTest()
        {
            Assert.IsTrue(builder.BuildLaser() is BlueLaser);
        }

        [TestMethod()]
        public void BuildWheelsTest()
        {
            List<Wheel> wheels = builder.BuildWheels();
            Assert.IsTrue(wheels.Count == 3);
            int thinwheels = 0;
            int thickwheels = 0;
            foreach(Wheel wheel in wheels)
            {
                if(wheel is ThinWheel)
                {
                    thinwheels++;
                }
                if(wheel is ThickWheel)
                {
                    thickwheels++;
                }
            }
            Assert.IsTrue(thinwheels == 1);
            Assert.IsTrue(thickwheels == 2);
        }

        [TestMethod()]
        public void BuildWingsTest()
        {
            List<Wing> wings = builder.BuildWings();
            Assert.IsTrue(wings.Count == 4);
            foreach(Wing wing in wings)
            {
                Assert.IsTrue(wing is SilverWing);
            }
        }
    }
}