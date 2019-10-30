using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem10: IProblem
    {
        public string Solve()
        {
            return SumOfPrimesBelow(2000000).ToString();  // TO DO optimization
        }

        long SumOfPrimesBelow(int n)
        {
            var primes = Helpers.PrimesUpTo(n);

            return Helpers.SumOfListElem(primes);
        }
    }
}
