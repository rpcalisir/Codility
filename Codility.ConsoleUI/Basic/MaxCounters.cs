using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// You are given N counters, initially set to 0, and you have two possible operations on them:
    //    increase(X) − counter X is increased by 1,
    //max counter − all counters are set to the maximum value of any counter.
    //A non-empty array A of M integers is given.This array represents consecutive operations:
    //if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
    //if A[K] = N + 1 then operation K is max counter.
    //For example, given integer N = 5 and array A such that:
    //    A[0] = 3
    //    A[1] = 4
    //    A[2] = 4
    //    A[3] = 6
    //    A[4] = 1
    //    A[5] = 4
    //    A[6] = 4
    //the values of the counters after each consecutive operation will be:
    //    (0, 0, 1, 0, 0)
    //    (0, 0, 1, 1, 0)
    //    (0, 0, 1, 2, 0)
    //    (2, 2, 2, 2, 2)
    //    (3, 2, 2, 2, 2)
    //    (3, 2, 2, 3, 2)
    //    (3, 2, 2, 4, 2)
    //The goal is to calculate the value of every counter after all operations.
    //Write a function:
    //class Solution { public int[] solution(int N, int[] A); }
    //    that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.
    //    Result array should be returned as an array of integers.
    //    For example, given:
    //        A[0] = 3
    //        A[1] = 4
    //        A[2] = 4
    //        A[3] = 6
    //        A[4] = 1
    //        A[5] = 4
    //        A[6] = 4
    //    the function should return [3, 2, 2, 4, 2], as explained above.
    ///
    ///
    /// Yani;
    /// A dizisinin her bir elemanının değerine karşılık gelen counter X(A[0] için 3), 1<=X<=N aralığında ise;
    /// Counter 3'ü bir arttır, eğer aralıkta değilse (N = 5 için) 5 counter'ın değerini de o anki en büyük counter'a eşitle.
    /// </summary>
    class MaxCounters
    {
        public static int[] Solution(int N, int[] A)
        {

            ////Similar to mine(to get rid of zero indexed problem)
            //int[] counters = new int[N];
            //for (int i = 0; i < A.Length; i++)
            //{
            //    int X = A[i];
            //    if (X >= 1 && X <= N)
            //    { // this encodes increment(X), with X=A[i] 
            //        counters[X - 1] = counters[X - 1] + 1; //-1, because our index is 0-based  
            //    }
            //    if (X == N + 1)
            //    {// this encodes setting all counters to the max value
            //        int tmpMax = counters.Max();
            //        for (int h = 0; h < counters.Length; h++)
            //        {
            //            counters[h] = tmpMax;
            //        }
            //    }
            //}
            //return counters;

           //%100
            int[] result = new int[N];
            int maximum = 0;
            int resetLimit = 0;

            for (int K = 0; K < A.Length; K++)
            {
                if (A[K] < 1 || A[K] > N + 1)
                    throw new InvalidOperationException();

                if (A[K] >= 1 && A[K] <= N)
                {
                    if (result[A[K] - 1] < resetLimit)
                    {
                        result[A[K] - 1] = resetLimit + 1;
                    }
                    else
                    {
                        result[A[K] - 1]++;
                    }

                    if (result[A[K] - 1] > maximum)
                    {
                        maximum = result[A[K] - 1];
                    }
                }
                else
                {
                    // inefficiency here
                    //for (int i = 0; i < result.Length; i++)
                    //    result[i] = maximum;
                    resetLimit = maximum;
                }
            }

            for (int i = 0; i < result.Length; i++)
                result[i] = Math.Max(resetLimit, result[i]);

            return result;

            ////My Solution
            //int[] counters = new int[N + 1];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (1 <= A[i] && A[i] <= N)
            //    {
            //        counters[A[i]]++;
            //    }
            //    else
            //    {
            //        for (int j = 1; j <= N; j++)
            //            counters[j] = counters.Max();
            //    }
            //}
            //return counters.Skip(1).ToArray();

            ////My Solution(Zero indexed problem fixed)
            //int[] counters = new int[N];

            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (1 <= A[i] && A[i] <= N)
            //    {
            //        counters[A[i]-1]++;
            //    }
            //    else
            //    {
            //        for (int j = 0; j < N; j++)
            //            counters[j] = counters.Max();
            //    }
            //}
            //return counters;
        }
    }
}
