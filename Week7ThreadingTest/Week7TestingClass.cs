using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Diagnostics;
using System.Collections.Generic;
using Week7Threading;

namespace Week7ThreadingTest
{
    [TestClass]
    public class Week7TestingClass
    {
        [TestMethod]
        public void LagMakerTest()
        {
            LagSwitch.LagMaker();
        }
        [TestMethod]
        public void LagMakerThreadedTest()
        {
            LagSwitch.LagMakerThreaded();
        }
    }
}
