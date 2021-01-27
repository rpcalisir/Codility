using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// Write a function
    //class Solution { public int solution(int[] A); }
    //that, given an array A consisting of N integers, returns the number of distinct values in array A.
    //For example, given array A consisting of six elements such that:
    // A[0] = 2    A[1] = 1    A[2] = 1
    // A[3] = 2    A[4] = 3    A[5] = 1
    //the function should return 3, because there are 3 distinct values appearing in array A, namely 1, 2 and 3.
    /// </summary>
    public class DistinctValuesInArray
    {
        public static int Solution(int[] A)
        {
            //My solution
            List<int> distincts = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (!distincts.Contains(A[i]))
                {
                    distincts.Add(A[i]);
                }
            }
            return distincts.Count;
        }
    }
}
