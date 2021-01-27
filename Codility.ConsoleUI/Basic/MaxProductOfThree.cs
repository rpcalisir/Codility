using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).
    //    For example, array A such that:
    //  A[0] = -3
    //  A[1] = 1
    //  A[2] = 2
    //  A[3] = -2
    //  A[4] = 5
    //  A[5] = 6
    //contains the following example triplets:
    //(0, 1, 2), product is −3 * 1 * 2 = −6
    //(1, 2, 4), product is 1 * 2 * 5 = 10
    //(2, 4, 5), product is 2 * 5 * 6 = 60
    //Your goal is to find the maximal product of any triplet.
    //Write a function:
    //class Solution { public int solution(int[] A); }
    //    that, given a non-empty array A, returns the value of the maximal product of any triplet.
    //    For example, given array A such that:
    //      A[0] = -3
    //      A[1] = 1
    //      A[2] = 2
    //      A[3] = -2
    //      A[4] = 5
    //      A[5] = 6
    //    the function should return 60, as the product of triplet (2, 4, 5) is maximal.
    /// </summary>
    public class MaxProductOfThree
    {
        public static int Solution(int[] A)
        {
            //My solution Long Way
            int maxProduct = int.MinValue, product = 0;

            for (int P = 0; P < A.Length - 2; P++)
                for (int Q = P + 1; Q < A.Length - 1; Q++)
                    for (int R = Q + 1; R < A.Length; R++)
                    {
                        product = A[P] * A[Q] * A[R];
                        if (product > maxProduct)
                            maxProduct = product;
                    }
            return maxProduct;
        }
    }
}
