using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{

    /// <summary>
    /// A non-empty array A consisting of N integers is given. A pair of integers (P, Q), such that 0 ≤ P < Q < N, is called a slice of
    /// array A (notice that the slice contains at least two elements). The average of a slice (P, Q) is the sum of
    /// A[P] + A[P + 1] + ... + A[Q] divided by the length of the slice. To be precise, the average equals 
    /// (A[P] + A[P + 1] + ... + A[Q]) / (Q − P + 1).
    //    For example, array A such that:
    //    A[0] = 4
    //    A[1] = 2
    //    A[2] = 2
    //    A[3] = 5
    //    A[4] = 1
    //    A[5] = 5
    //    A[6] = 8
    //contains the following example slices:
    //slice(1, 2), whose average is (2 + 2) / 2 = 2;
    //slice(3, 4), whose average is (5 + 1) / 2 = 3;
    //slice(1, 4), whose average is (2 + 2 + 5 + 1) / 4 = 2.5.
    //The goal is to find the starting position of a slice whose average is minimal.
    //Write a function:
    //class Solution { public int solution(int[] A); }
    //    that, given a non-empty array A consisting of N integers, returns the starting position of the slice with the minimal average.If there is more than one slice with a minimal average, you should return the smallest starting position of such a slice.
    //   For example, given array A such that:
    //       A[0] = 4
    //       A[1] = 2
    //       A[2] = 2
    //       A[3] = 5
    //       A[4] = 1
    //       A[5] = 5
    //       A[6] = 8
    //   the function should return 1, as explained above.
    /// </summary>
    public class MinAvgTwoSlice
    {
        public static int Solution(int[] A)
        {
            //Solution %100
            //It checks the average of all subarrays formed with 2 elements and 3 elements. 
            //Any group of more elements will have an average >= to one of these groups, so the smaller group would be optimal.
            double minAvg = double.MaxValue;
            int minI = int.MaxValue;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if ((A[i] + A[i + 1]) / 2.0 < minAvg)
                {
                    minAvg = (A[i] + A[i + 1]) / 2.0;
                    minI = i;
                }
                if (i < A.Length - 2)
                    if ((A[i] + A[i + 1] + A[i + 2]) / 3.0 < minAvg)
                    {
                        minAvg = (A[i] + A[i + 1] + A[i + 2]) / 3.0;
                        minI = i;
                    }
            }
            return minI;

            //My Solution %40
            //double min = double.MaxValue, average = 0;
            //int sum = 0, result = 0, minP = int.MaxValue;

            //for (int P = 0; P < A.Length; P++)
            //{
            //    for (int Q = 0; Q < A.Length; Q++)
            //    {
            //        if (P < Q)
            //        {
            //            for (int i = P; i <= Q; i++)
            //            {
            //                sum += A[i];
            //                average = sum / (Q - P + 1);
            //            }
            //            if (average < min)
            //            {
            //                min = average;
            //                if (P < minP)
            //                {
            //                    result = P;
            //                    minP = P;
            //                }
            //            }
            //        }
            //    }
            //    sum = 0;
            //    minP = int.MaxValue;
            //}
            //return result;
        }
    }
}
