using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem2 : IProblem
    {
        public string Solve()
        {
            return Helpers.SumOfListElem(EvenFibonacciNumbersUpTo(4000000)).ToString();
        }

        List<int> EvenFibonacciNumbersUpTo(int n)
        {
            List<int> fibonacci = new List<int>(){1, 1};
            List<int> response = new List<int>();
            for (int i = 2; fibonacci[i-1] < n; i++)
            {
                fibonacci.Add(fibonacci[i - 1] + fibonacci[i - 2]);
                if (fibonacci[i] % 2 == 0)
                {
                    response.Add(fibonacci[i]);
                }
            }

            return response;
        }
    }
}
