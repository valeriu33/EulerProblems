using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems.Infrastructure
{
    public static class NrOfDivisors
    {
        public static Tuple<bool[], bool[], long[]> SieveOfEratosthenes(long n)
        {
            bool[] prime = new bool[n + 1];
            bool[] primeSquare = new bool[(n * n) + 1];
            long[] a = new long[n+1];

            for (long i = 2; i <= n; i++)
                prime[i] = true;

            for (long i = 0; i < ((n * n) + 1); i++)
                primeSquare[i] = false;

            prime[1] = false;

            for (long p = 2; p * p <= n; p++)
            {

                if (prime[p])
                {
                    for (long i = p * 2; i <= n; i += p)
                        prime[i] = false;
                }
            }

            int j = 0;
            for (long p = 2; p <= n; p++)
            {
                if (prime[p])
                {
                    a[j] = p;
                    primeSquare[p * p] = true;
                    j++;
                }
            }

            var response= new Tuple<bool[], bool[], long[]>(prime,
                primeSquare,
                a);

            return response;
        }

        public static int CountDivisors(long n, bool[] prime,
            bool[] primeSquare, long[] primesUpToN)
        {
            if (n == 1)
                return 1;
           
            int ans = 1;

            for (int i = 0; ; i++)
            {
                if (primesUpToN[i] * primesUpToN[i] * primesUpToN[i] > n)
                    break;

                int cnt = 1;

                while (n % primesUpToN[i] == 0)
                {
                    n = n / primesUpToN[i];

                    cnt = cnt + 1;
                }

                ans = ans * cnt;
            }

            if (prime[n])
                ans = ans * 2;

            else if (primeSquare[n])
                ans = ans * 3;

            else if (n != 1)
                ans = ans * 4;

            return ans;
        }
    }
}
