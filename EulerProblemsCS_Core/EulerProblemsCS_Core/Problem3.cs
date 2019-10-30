using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem3 : IProblem
    {
        public string Solve()
        {
            //            return Factorization(600851475143).Max().ToString();

            return LargestPrimeFactor(600851475143).ToString();
        }

        long LargestPrimeFactor(long n)
        {
            long response = -1;

            while (n % 2 == 0)
            {
                n /= n;
                response = 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    response = i;
                    n = n / i;
                }
            }

            if (n > 2)
            {
                response = n;
            }

            return response;
        }
    }
}
