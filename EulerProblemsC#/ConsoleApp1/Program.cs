using System;
using System.Collections.Immutable;
using System.Linq;

public class SortedSearch
{
    public static int CountNumbers(int[] sortedArray, int lessThan)
    {
        int len = sortedArray.Length;

        if (sortedArray[len - 1] < lessThan)
        {
            return len;
        }
        if (sortedArray[0] >= lessThan)
        {
            return 0;
        }

        return Array.IndexOf(sortedArray, CountNumbersRecoursiveShit(sortedArray, lessThan));
    }

    public static int CountNumbersRecoursiveShit(int[] sortedArray, int lessThan)
    {
        int len = sortedArray.Length;

        if (len == 1) return sortedArray[0];


        if (sortedArray[len / 2] >= lessThan)
        {
            return CountNumbersRecoursiveShit(sortedArray.Take(len / 2).ToArray(), lessThan);
        }
        else
        {
            return CountNumbersRecoursiveShit(sortedArray.TakeLast(len / 2).ToArray(), lessThan);
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(SortedSearch.CountNumbers(new int[]
        {
            1, 3, 5, 7, 8,
            9, 11, 13, 15, 20,
            25, 27, 28, 29, 30,
            45, 50, 51, 52, 55
        },
            2));
        Console.Read();
    }
}