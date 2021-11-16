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
    public class SilverWingTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Wing wing = new SilverWing();
            Assert.AreEqual("a silver wing", wing.Description());
        }
    }
}