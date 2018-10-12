using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace Week7Threading
{
    public class LagSwitch
    {
        static void Main(string[] args)
        {
            Stopwatch timeTraker = new Stopwatch();
            timeTraker.Start();
            LagMaker();
            LagMaker();
            TimeSpan calculationTime = timeTraker.Elapsed;
            string elapsedMilliseconds = String.Format("{00:00}", calculationTime.Milliseconds);
            string elapsedSeconds = String.Format("{00:00}", calculationTime.Seconds);
            Console.WriteLine("It took " + elapsedSeconds + " seconds and " + elapsedMilliseconds + " milliseconds to complete two intensive calculations with only one thread.");
            timeTraker.Stop();
            timeTraker.Reset();
            timeTraker.Start();
            LagMakerThreaded();
            LagMakerThreaded();
            Console.WriteLine("Two threads have started.");
        }
        public static void LagMaker()
        {
            double results = DoIntensiveCalculations();
        }
        public static void LagMaker2()
        {
            Stopwatch timeTraker = new Stopwatch();
            timeTraker.Start();
            double results = DoIntensiveCalculations();
            TimeSpan calculationTime = timeTraker.Elapsed;
            string elapsedMilliseconds = String.Format("{00:00}", calculationTime.Milliseconds);
            string elapsedSeconds = String.Format("{00:00}", calculationTime.Seconds);
            Console.WriteLine("It took " + elapsedSeconds + " seconds and " + elapsedMilliseconds + " milliseconds to complete the asynchronous thread.");
            timeTraker.Stop();
        }
        public static void LagMakerThreaded()
        {
            var thread = new Thread(() =>
            {
                LagMaker2();
            });
            thread.Start();
        }

        public static double DoIntensiveCalculations()
        {
            // We are simulating intensive calculations. 
            // by doing nonsens divisions and multiplications.
            double result = 10000d;
            var maxValue = Int32.MaxValue >> 4;
            for (int i = 1; i < maxValue; i++)
            {
                if (i % 2 == 0)
                {
                    result /= i;
                }
                else
                {
                    result *= i;
                }
            }
            return result;
        }
    }
}
