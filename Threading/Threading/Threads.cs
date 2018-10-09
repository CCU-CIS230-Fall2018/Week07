using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel;

namespace Threading
{
    class Threads
    {
        public static void CreateStopwatch()
        {
            Stopwatch sw = new Stopwatch.StartNew();
        }
        public static void RunSequential()
        {
            double result = 0d;
            result += ReadDataFromIO();
            result += DoIntensiveCalculations();
        }
        public static double ReadDataFromIO()
        {
            // We are simulating an I/O by putting the current thread to sleep.
            Thread.Sleep(2000);
            return 10d;
        }

        public static Task<double> ReadDataFromIOAsync()
        {
            return Task.Run(new Func<double>(ReadDataFromIO));
        }
        public static double DoIntensiveCalculations()
        {

            // We are simulating intensive calculations 
            // by doing nonsens divisions and multiplications

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
