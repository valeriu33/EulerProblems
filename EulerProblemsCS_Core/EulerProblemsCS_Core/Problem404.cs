using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem404: IProblem
    {
        public string Solve()
        {
            var a = "1235945123";
            var b = a.ToList();
            b.Sort(delegate(char c1, char c2)
            {
                return int.Parse(c1.ToString()) - int.Parse(c2.ToString());
            });

            var c = "";
            b.ForEach(ch => c += ch);

            return c;
        }

        public async Task<int> GetFirst()
        {
            Thread.Sleep(1000);
            return 1;
        }

        public async Task<int> GetSecond()
        {
            Thread.Sleep(1500);
            return 2;
        }

        public async Task<int> GetThird()
        {
            Thread.Sleep(2000);
            return 3;
        }
    }
}
