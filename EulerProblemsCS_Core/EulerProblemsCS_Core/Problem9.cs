using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem9: IProblem
    {
        public string Solve()
        {
            return SpecialPythagoreanTriplet().ToString();
        }

        long SpecialPythagoreanTriplet()
        {
            for (int i = 1; i < 300; i++)
            {
                for (int j = i; j < 400; j++)
                {
                    if (int.TryParse(Math.Sqrt(i * i + j * j).ToString(), out int c))
                    {
                        if (i + j + c == 1000)
                            return i * j * c;
                    }
                }
            }

            return 0;
        }

        bool isPythagoreanTriplet(int a, int b, int c)
        {
            return a * a + b * b == c * c;
        }
    }
}
