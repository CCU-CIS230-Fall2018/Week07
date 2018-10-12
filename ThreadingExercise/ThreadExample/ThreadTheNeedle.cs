using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExample
{

    public class ThreadTheNeedle
    {

        static void Main(string[] args)
        {

            // We are using Stopwatch to time the code
            Stopwatch sw = Stopwatch.StartNew();

            RunWithThreads();

            // Write the time taken to complete intensive calculations to the console.
            Console.WriteLine("We're done in {0}ms!", sw.ElapsedMilliseconds);

            Utils.CommonFunctions.WaitForKeyWhehDebugging();

        }

        public static double RunWithThreads()
        {

            double result = 0d;

            // Create the thread to read from I/O
            var thread = new Thread(() => result = Utils.CommonFunctions.ReadDataFromIO());
            // Start the thread
            thread.Start();

            // Save the result of the calculation into another variable
            double result2 = Utils.CommonFunctions.DoIntensiveCalculations();

            // Wait for the thread to finish
            thread.Join();
            // Calculate the end result
            result += result2;

            // Print the result
            Console.WriteLine("The result is {0}", result);
            return result;

        }
    }
}
