using System;
using System.Linq;

namespace Find_Duplicate
{
    class Program
    {
        // Given an array of length (n+1) whose members belong to the set {1,2,3,...,n}. By the pigeonhole principle,
        // there must be a duplicate. Return the duplicate value.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 17 };
            int correctSum = 0;
            for (int i = 1; i <= arr.Length; i++){correctSum += i;}
            int missingAmnt = correctSum - arr.Sum();
            int duplicate = arr.Length - missingAmnt;
            Console.WriteLine(duplicate);
        }
    }
}
