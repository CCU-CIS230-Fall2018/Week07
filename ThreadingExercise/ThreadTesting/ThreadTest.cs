using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ThreadExample;
using System.Diagnostics;



namespace ThreadTesting
{
    [TestClass]
    public class ThreadTest
    {
        [TestMethod]
        public void ThreadInnitiates()
        {
            double expectedResult = 11.377415983156;
            Stopwatch timer = Stopwatch.StartNew();
            double calculatedResult = ThreadExample.ThreadTheNeedle.RunWithThreads();

            Assert.IsNotNull(timer);
            Assert.AreEqual(expectedResult.ToString(), calculatedResult.ToString());

        }

        [TestMethod]
        public void TimerRunsInBackgroundSeparately()
        {
            //This test method shows that the stopwatch persists behind in the background
            // even as new threads start new calculations.

            // One Thread instance with its own timer.
            Stopwatch timer = Stopwatch.StartNew();
            double calculatedResult = ThreadExample.ThreadTheNeedle.RunWithThreads();
            double timeStamp1 = timer.ElapsedMilliseconds;

            //Second Thread instance with same timer.
            double calculatedResult2 = ThreadExample.ThreadTheNeedle.RunWithThreads();
            double timeStamp2 = timer.ElapsedMilliseconds;

            Assert.AreNotSame(timeStamp1, timeStamp2);
        }
    }
}
