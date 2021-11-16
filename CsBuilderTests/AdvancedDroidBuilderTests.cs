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
    public class AdvancedDroidBuilderTests
    {
        private DroidBuilder builder;
        [TestInitialize()]
        public void Initialize()
        {
            builder = new AdvancedDroidBuilder();
        }
        [TestCleanup()]
        public void Cleanup()
        {
            builder = null;
        }
        [TestMethod()]
        public void BuildLaserTest()
        {
            Assert.IsTrue(builder.BuildLaser() is RedLaser);
        }

        [TestMethod()]
        public void BuildWheelsTest()
        {
            List<Wheel> wheels = builder.BuildWheels();
            Assert.IsTrue(wheels.Count == 4);
            foreach(Wheel wheel in wheels)
            {
                Assert.IsTrue(wheel is ThickWheel);
            }
        }

        [TestMethod()]
        public void BuildWingsTest()
        {
            List<Wing> wings = builder.BuildWings();
            Assert.IsTrue(wings.Count == 4);
            foreach(Wing wing in wings)
            {
                Assert.IsTrue(wing is GoldenWing);
            }
        }
    }
}