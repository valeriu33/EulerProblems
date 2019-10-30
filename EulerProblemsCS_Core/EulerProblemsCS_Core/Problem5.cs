using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem5 : IProblem
    {
        public string Solve()
        {
//            StringBuilder response = new StringBuilder();
//            foreach (var factor in Helpers.Factorization(30240))
//            {
//                response.Append(factor + " ");
//            }
//
//            return response.ToString();

            return SmallestNrDivisibleByAllNrFrom1To(10).ToString();
        }

        long SmallestNrDivisibleByAllNrFrom1To(long n)
        {
            List<long> p = Helpers.PrimesUpTo(100);
            long[] a = new long[100];
            long N = 1;
            int i = 1;
            bool check = true;
            double limit = Math.Sqrt(n);
            while (p[i] <= n)
            {
                a[i] = 1;
                if (check)
                {
                    if (p[i] <= limit)
                    {
                        a[i] = (long) Math.Floor(Math.Log(n) / Math.Log(p[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }

                N = (long) (N * Math.Pow(p[i], a[i]));
                i = i + 1;
            }

            return N;
        }
//
//        /*
//         *k = 20
//            N = 1
//            i = 1
//            check = true
//            limit = sqrt(k)
//            while p[i] <= k
//             a[i] = 1
//             if check then
//             if p[i] <= limit then
//             a[i] = floor( log(k) / log(p[i]) )
//             else
//             check = false
//             end if
//             end if
//             N = N * p[i] ^ a[i]
//             i = i + 1
//            end while
//            output N 

    }
}
