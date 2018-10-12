using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> FindPrimes(int max)
            {
          
                var isPrime = new bool[max + 1];
                var sqrt = (int)Math.Sqrt(max);

                Parallel.For(1, sqrt, x =>
                {
                    int xx = x * x;
                    for (int y = 1; y <= sqrt; y++)
                    {
                        int yy = y * y;
                        var n = 4 * xx + yy;
                        if (n <= max && (n % 12 == 1 || n % 12 == 5))
                            isPrime[n] ^= true;

                        n = primeMethod(xx, yy);
                        if (n <= max && n % 12 == 7)
                            isPrime[n] ^= true;

                        n = 3 * xx - yy;
                        if (x > y && n <= max && n % 12 == 11)
                        {
                            isPrime[n] ^= true;
                        }
                    }
                });

                var primes = new List<int>() { 2, 3 };
                for (int n = 5; n <= sqrt; n++)
                {
                    if (isPrime[n])
                    {
                        primes.Add(n);
                        int nn = n * n;
                        for (int k = nn; k <= max; k += nn)
                            isPrime[k] = false;
                    }
                }

                for (int n = sqrt + 1; n <= max; n++)
                    if (isPrime[n])
                        primes.Add(n);

                return primes;
            }
        }

        private static int primeMethod(int xx, int yy)
        {
            return 3 * xx + yy;
        }

        private static bool PrimeMethod()
        {
            return false;
        }
    }
}
