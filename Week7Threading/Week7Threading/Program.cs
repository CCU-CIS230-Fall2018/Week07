using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7Threading
{
    class Program
    {
    static void Main(string[] args)
    {
            string message = "Doing The Thing";
            var tooLong = new TakesTooLong();
            tooLong.DoTheThing();

            while (1 == 1)
            {
                Console.WriteLine(message);
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}
