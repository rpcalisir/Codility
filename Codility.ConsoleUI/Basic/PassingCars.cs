using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A non-empty array A consisting of N integers is given. The consecutive elements of array A represent consecutive cars on 
    /// a road.
    //    Array A contains only 0s and/or 1s:
    //  0 represents a car traveling east,
    //  1 represents a car traveling west.
    //  The goal is to count passing cars.We say that a pair of cars (P, Q), where 0 ≤ P<Q<N, is passing when P is traveling to the 
    //  east and Q is traveling to the west.
    //  For example, consider array A such that:
    //  A[0] = 0
    //  A[1] = 1
    //  A[2] = 0
    //  A[3] = 1
    //  A[4] = 1
    //  We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).
    //  Write a function:
    //  class Solution { public int solution(int[] A); }
    //    that, given a non-empty array A of N integers, returns the number of pairs of passing cars.
    //    The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.
    //  For example, given:
    //  A[0] = 0
    //  A[1] = 1
    //  A[2] = 0
    //  A[3] = 1
    //  A[4] = 1
    //  sthe function should return 5, as explained above.
    /// </summary>
    public class PassingCars
    {
        public static int Solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int pairs = 0;

            for (int P = 0; P < A.Length - 1; P++)
            {
                if (A[P] == 0)
                {
                    for (int Q = P + 1; Q < A.Length; Q++)
                    {
                        if (A[Q] == 1)
                            pairs++;
                    }
                }
            }
            return pairs > 1000000000 ? -1 : pairs;
        }
    }
}
