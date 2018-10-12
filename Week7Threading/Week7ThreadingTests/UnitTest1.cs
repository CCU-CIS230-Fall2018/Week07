using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Week7Threading;

namespace Week7ThreadingTests
{
    [TestClass]
    public class Test_For_Async
    {
        [TestMethod]
        public async void Run_Test()
        {
            string message = "Test The Thing";
            var tooLong = new TakesTooLong();
            await tooLong.DoTheThing();
            Assert.AreEqual("Test The Thing", message);

            while (1 == 1)
            {
                Console.WriteLine(message);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
