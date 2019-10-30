using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem6 : IProblem
    {
        public string Solve()
        {
            int n = 100;
            return (SquareOfSumOfNrsUpTo(n) - SumOfSquaresOfNrsUpTo(n)).ToString();
//            return ((n * n + n) / 2).ToString();
        }

        long SquareOfSumOfNrsUpTo(int n)
        {
            return ((n * n + n)*(n*n + n)) / 4;
        }

        long SumOfSquaresOfNrsUpTo(int n)
        {
            long response = 0;
            for (int i = 1; i <= n; i++)
            {
                response = response + i * i;
            }
            return response;
        }
    }
}
