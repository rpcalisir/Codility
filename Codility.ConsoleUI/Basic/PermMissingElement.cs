using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// An array A consisting of N different integers is given. The array contains integers in the range [1..(N + 1)], 
    /// which means that exactly one element is missing.
    /// Your goal is to find that missing element.
    /// Write a function:
    /// class Solution { public int solution(int[] A); }
    /// that, given an array A, returns the value of the missing element.
    /// For example, given array A such that:
    ///  A[0] = 2
    ///  A[1] = 3
    ///  A[2] = 1
    ///  A[3] = 5
    /// the function should return 4, as it is the missing element.
    /// </summary>
    public static class PermMissingElement
    {
        public static int Solution(int[] A)
        {
            //Better solution
            int sum = A.Sum();
            int n = A.Length + 1;
            n = n * (n + 1) / 2;
            return n - sum;

            // First Attempt
            //Array.Sort(A);

            //int flag = A[0];
            //int result = 0;
            //for (int i = 1; i < A.Length; i++)
            //{
            //    if (A[i] == (flag + 1))
            //        flag++;
            //    else
            //        result = flag + 1;
            //}
            //return result;

            //My solution Second Attempt (%100)
            //int flag = 1;
            //Array.Sort(A);
            //int result;
            //for (int i = 0; i <= A.GetUpperBound(0); i++)
            //{
            //    if (A[i] == flag)
            //        flag++;
            //    else
            //        result = flag;
            //}
            //return flag;

        }
    }
}
