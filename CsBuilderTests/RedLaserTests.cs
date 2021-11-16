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
    public class RedLaserTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Laser laser = new RedLaser();
            Assert.AreEqual("a red laser beam", laser.Description());
        }
    }
}