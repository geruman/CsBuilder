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
    public class BlueLaserTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Laser laser = new BlueLaser();
            Assert.AreEqual("a blue laser beam", laser.Description());
        }
    }
}