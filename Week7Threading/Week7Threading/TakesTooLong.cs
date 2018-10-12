using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Threading
{
    public class TakesTooLong
    {
        public async Task DoTheThing()
        {
            await Task.Run(() =>
            {
                TimeWaster();
            });
        }

        public static async Task<string> TimeWaster()
        {
            int fakeList;

            // Let code run until fakeList reaches it limit to see how
            // it is made to run asynchronus.
            for (fakeList = 0; fakeList < 15; fakeList++)
            {
                Console.WriteLine(fakeList);
                System.Threading.Thread.Sleep(700);
            }

            return "Counter = " + fakeList;
        }
    }
}
