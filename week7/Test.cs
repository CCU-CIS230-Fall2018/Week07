using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Test
    {
        static void CompileWith(string[] args)
        {
            Console.WriteLine("Type the int max for the primes you want to see: ");

            var number = Console.ReadLine();

            FindPrimes(number);

            Console.WriteLine("The primes are: ", FindPrimes());
        }

        private static int FindPrimes()
        {
            throw new NotImplementedException();
        }

        private static void FindPrimes(string number)
        {
            throw new NotImplementedException();
        }
    }
}
