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
    public class DroidBuilderTests
    {
        [TestMethod()]
        public void GetDroidTest()
        {
            DroidBuilder builder = new SimpleDroidBuilder();
            Assert.IsTrue(builder.GetDroid() is Droid);
            builder = new AdvancedDroidBuilder();
            Assert.IsTrue(builder.GetDroid() is Droid);
        }
    }
}