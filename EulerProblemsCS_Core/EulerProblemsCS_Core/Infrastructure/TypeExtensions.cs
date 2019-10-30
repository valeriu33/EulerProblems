using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    static class TypeExtensions
    {
        public static int[,] ToIntMatrix(this string str)
        {

            var lines = str.Split('\n');

            int[,] result = new int[lines.Length, lines[0].Split(' ').Length];

            for (var i = 0; i < lines.Length; i++)
            {
                var numbers = lines[i].Split(' ');

                for (var j = 0; j < numbers.Length; j++)
                {
                    result[i, j] = Int32.Parse(numbers[j]);
                }
            }

            return result;
        }
    }
}
