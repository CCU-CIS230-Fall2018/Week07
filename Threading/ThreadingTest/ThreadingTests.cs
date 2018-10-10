using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Threading;

namespace ThreadingTest
{
    [TestClass]
    public class ThreadingTests
    {
        [TestMethod]
        public void ThreadingExample()
        {
            Stopwatch sw = Stopwatch.StartNew();
            double reslt = Threads.RunSequential();
            Console.WriteLine($"We're done in {sw.ElapsedMilliseconds}");
            Assert.AreEqual("10.688707991578", reslt.ToString());

        }
       
    }
}
