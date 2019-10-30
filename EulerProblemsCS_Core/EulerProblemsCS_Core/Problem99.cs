using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblems
{
    class Problem99: IProblem
    {
        public string Solve()
        {
            int[] a = {2, 3, 4};
            int[] b = {1, 3, 5};
            int[] c = {2, 10, 11};
            int[][] input = {a, b, c};
            // expected result 1, 2, 2, 3, 3 ,4, 5, 10, 11
            MergeSortedArrays(input).ToList().ForEach(i => Console.WriteLine(i));
            return "";
        }

        private int[] MergeSortedArrays(int[][] inputMatrix)
        {
            var nrOfArraysInMatrix = inputMatrix.Length;

            var resultArrayLength = 0;
            foreach (var array in inputMatrix)
                resultArrayLength += array.Length;

            int[] resultArray = new int[resultArrayLength];

            int[] minIndexesInArrays = new int[nrOfArraysInMatrix];
            minIndexesInArrays.Initialize(); // assigns 0 to all values

            for (int i = 0; i < resultArrayLength; i++)
            {
                var allTheMins = new int[nrOfArraysInMatrix]; 
                for (var j = 0; j < nrOfArraysInMatrix; j++)
                    allTheMins[j] = inputMatrix[j][minIndexesInArrays[j]]; 
                // we take all the minimal numbers from arrays

                var currentMin = allTheMins.Min();
                resultArray[i] = currentMin;

                for (var j = 0; j < nrOfArraysInMatrix; j++)
                {
                    var array = inputMatrix[j];
                    if (currentMin == array[minIndexesInArrays[j]])
                    {
                        if (minIndexesInArrays[j] < array.Length - 1)
                            minIndexesInArrays[j]++;
                        else
                        {
                            minIndexesInArrays[j] = array.Length - 1;
                            array[minIndexesInArrays[j]] = int.MaxValue;
                        }
                        break;
                    }
                }
            }

            return resultArray;
        }
    }
}
