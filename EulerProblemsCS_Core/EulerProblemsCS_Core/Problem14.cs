using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem14 : IProblem
    {
        public string Solve()
        {
            return "";
        }

        int LongestChainNumber(int until)
        {
            int maxNum = 0;

            for (int i = 0; i < until; i++)
            {
                int temp = ChainLength(i);
                if (temp > maxNum)
                {
                    maxNum = temp;
                }
            }
            return maxNum;
        }

        int ChainLength(int n)
        {
            int next = 0;
            while (n == 1)
            {
                
            }

            return 0;
        }
    }
}
