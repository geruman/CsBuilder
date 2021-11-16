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
    public class GoldenWingTests
    {
        [TestMethod()]
        public void DescriptionTest()
        {
            Wing wing = new GoldenWing();
            Assert.AreEqual("A golden wing", wing.Description());
        }
    }
}