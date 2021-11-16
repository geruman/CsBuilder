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
    public class ThickWheelTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Wheel wheel = new ThickWheel();
            Assert.AreEqual("a thick wheel", wheel.Description());
        }
    }
}