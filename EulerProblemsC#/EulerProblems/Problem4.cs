using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem4 : IProblem
    {
        public string Solve()
        {
            return LargestPalindromeProductOf2Digits().ToString();
        }

        int LargestPalindromeProductOf2Digits()
        {
            List<int> palindromes = new List<int>();
            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= i; j--)
                {
                    if (Helpers.IsPalindrome(i * j))
                    {
                        palindromes.Add(i * j);
                    }
                }
            }

            return palindromes.Max();
        }
    }
}
