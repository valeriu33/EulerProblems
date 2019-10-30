using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem1 : IProblem
    {
        public string Solve()
        {
            return Helpers.SumOfArrayElem(AllMultiplesOf3and5Below(1000)).ToString();
        }

        int[] AllMultiplesOf3and5Below(int n)
        {
            int[] response = new int[n];
            for (int i = 0,j = 0; i < n; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    response[j++] = i;
                }
            }

            return response;
        }
    }
}
