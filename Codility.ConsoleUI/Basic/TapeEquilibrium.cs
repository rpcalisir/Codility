using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A non-empty array A consisting of N integers is given. Array A represents numbers on a tape.
    //    Any integer P, such that 0 < P<N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and 
    //      A[P], A[P + 1], ..., A[N − 1].
    //    The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
    //In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
    //For example, consider array A such that:
    //  A[0] = 3
    //  A[1] = 1
    //  A[2] = 2
    //  A[3] = 4
    //  A[4] = 3
    //We can split this tape in four places:
    //P = 1, difference = | 3 − 10| = 7
    //P = 2, difference = | 4 − 9| = 5
    //P = 3, difference = | 6 − 7| = 1
    //P = 4, difference = | 10 − 3| = 7
    //Write a function:
    //class Solution { public int solution(int[] A); }
    //    that, given a non-empty array A of N integers, returns the minimal difference that can be achieved.
    //    For example, given:
    //  A[0] = 3
    //  A[1] = 1
    //  A[2] = 2
    //  A[3] = 4
    //  A[4] = 3
    //the function should return 1, as explained above.
    /// </summary>
    public static class TapeEquilibrium
    {
        public static int Solution(int[] A)
        {
            //My Solution
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int max = int.MaxValue;
            for (int i = 0; i <= A.GetUpperBound(0); i++)
            {
                var first = A.Take(i).ToArray().Sum();
                var second = A.Skip(i).ToArray().Sum();

                int diff = Math.Abs(first - second);
                if (diff < max)
                {
                    max = diff;
                }
            }
            return max;

            //Better Performance
            //long leftSum = 0;
            //long rightSum = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    rightSum += A[i];
            //}

            //long minDifference = int.MaxValue;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    leftSum += A[i];
            //    rightSum -= A[i];
            //    long difference = Math.Abs(leftSum - rightSum);
            //    minDifference = Math.Min(minDifference, difference);
            //}

            //return (int)minDifference;
        }
    }
}
