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
    public class ThinWheelTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Wheel wheel = new ThinWheel();
            Assert.AreEqual("a thin wheel", wheel.Description());
        }
    }
}