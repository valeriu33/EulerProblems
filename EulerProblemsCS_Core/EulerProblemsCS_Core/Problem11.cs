using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem11: IProblem
    {
        public string Solve()
        {
            return GreatestProductOfFourAdjacent().ToString();
        }

        private long GreatestProductOfFourAdjacent()
        {
            var matrix = Helpers.ReadFileContent("Problem11").ToIntMatrix();

            var results = new []
            {
                GreatestProductOfFourVertical(matrix),
                GreatestProductOfFourHorizontal(matrix),
                GreatestProductOfFourDiagonal(matrix),
                GreatestProductOfFourDiagonalSecondary(matrix)
            };

            return results.Max();
        }

        private long GreatestProductOfFourVertical(int[,] matrix)
        {
            long max = 0;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0) - 4; i++)
                {
                    var product = matrix[i, j] * matrix[i + 1, j] * matrix[i + 2, j] *
                                  matrix[i + 3, j];
                    if (product > max) max = product;
                }
            }

            return max;
        }

        private long GreatestProductOfFourHorizontal(int[,] matrix)
        {
            long max = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 4; j++)
                {
                    var product = matrix[i, j] * matrix[i, j + 1] * matrix[i, j + 2] *
                                  matrix[i, j + 3];
                    if (product > max) max = product;
                }
            }

            return max;
        }

        private long GreatestProductOfFourDiagonal(int[,] matrix)
        {
            long max = 0;

            for (int i = 0; i < matrix.GetLength(0) - 4; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 4; j++)
                {
                    var product = matrix[i, j] * matrix[i + 1, j + 1] * matrix[i + 2, j + 2] *
                                  matrix[i + 3, j + 3];
                    if (product > max) max = product;
                }
            }

            return max;
        }

        private long GreatestProductOfFourDiagonalSecondary(int[,] matrix)
        {
            long max = 0;

            for (int i = 0; i < matrix.GetLength(0) - 4; i++)
            {
                for (int j = 3; j < matrix.GetLength(1); j++)
                {
                    var product = matrix[i, j] * matrix[i + 1, j - 1] * matrix[i + 2, j - 2] *
                                  matrix[i + 3, j - 3];
                    if (product > max) max = product;
                }
            }

            return max;
        }
    }
}
