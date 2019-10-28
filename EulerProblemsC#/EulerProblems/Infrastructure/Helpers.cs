using System;
using System.Collections.Generic;
using System.IO;

namespace EulerProblems
{
    public static class Helpers
    {
        public static string ReadFileContent(string FileName)
        {
            return File.ReadAllText(
                Directory.GetCurrentDirectory() + "/input/" + FileName +
                ".txt");
        }

        public static void CwMatrix<T>(T[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j] + " ");
                }
            }
        }

        public static int SumOfArrayElem(int[] array)
        {
            int response = 0;
            for (int i = 0; i < array.Length; i++)
            {
                response += array[i];
            }

            return response;
        }

        public static long SumOfListElem(List<long> list)
        {
            long response = 0;
            for (int i = 0; i < list.Count; i++)
            {
                response += list[i];
            }

            return response;
        }

        public static int SumOfListElem(List<int> list)
        {
            int response = 0;
            for (int i = 0; i < list.Count; i++)
            {
                response += list[i];
            }

            return response;
        }

        public static List<long> PrimesUpTo(long n)
        {
            List<long> response = new List<long>() { 2 };

            for (long i = 3; i <= n; i = i + 2)
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
            }
            return response;
        }

        public static bool IsPalindrome(int n)
        {
            string nStr = n.ToString();
            for (int i = 0; i < nStr.Length / 2; i++)
            {
                if (nStr[i] != nStr[nStr.Length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }


        public static List<long> Factorization(long n)
        {
            List<long> response = new List<long>();

            while (n % 2 == 0)
            {
                n /= 2;
                response.Add(2);
            }

            for (int i = 3; i <= Math.Sqrt(n); i += 2)
            {
                while (n % i == 0)
                {
                    response.Add(i);
                    n = n / i;
                }
            }

            if (n > 2)
            {
                response.Add(n);
            }

            return response;
        }
    }
}
