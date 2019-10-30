using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem7 : IProblem
    {
        public string Solve()
        {
            return GetPrime(10001).ToString();
        }

        long GetPrime(int n)
        {
            List<long> response = new List<long>() { 2 };

            for (long i = 3; i < long.MaxValue; i = i + 2)
            {
                bool isPrime = true;
                foreach (var prime in response)
                {
                    if (i % prime == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) response.Add(i);
                if (response.Count.Equals(n))
                {
                    return response[response.Count - 1];
                }
            }
            return 0;
        }
    }
}
