using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A non-empty array A consisting of N integers is given. The array contains an odd number of elements, and each element of the array can be paired with another element that has the same value, except for one element that is left unpaired.
    /// For example, in array A such that:
    /// A[0] = 9  A[1] = 3  A[2] = 9
    /// A[3] = 3  A[4] = 9  A[5] = 7
    /// A[6] = 9
    ///    the elements at indexes 0 and 2 have value 9,
    ///    the elements at indexes 1 and 3 have value 3,
    ///    the elements at indexes 4 and 6 have value 9,
    ///    the element at index 5 has value 7 and is unpaired.
    ///    Write a function:
    //      class Solution { public int solution(int[] A); }
    //    that, given an array A consisting of N integers fulfilling the above conditions, returns the value of the unpaired element.
    //    For example, given array A such that:
    //      A[0] = 9  A[1] = 3  A[2] = 9
    //      A[3] = 3  A[4] = 9  A[5] = 7
    //      A[6] = 9
    //    the function should return 7, as explained in the example above.
    /// </summary>
    public static class OddNumberInArray
    {
        public static int Solution(int[] arr)
        {
            //My Way Dictionary
            //Dictionary<int, int> elementCounts = new Dictionary<int, int>();

            //int counter = 0;
            //for (int i = 0; i < A.Length; i++)
            //{
            //    if (!elementCounts.ContainsKey(A[i]))
            //    {
            //        elementCounts.Add(A[i], 1);
            //    }
            //    else
            //    {
            //        counter = elementCounts[A[i]];
            //        counter++;
            //        elementCounts[A[i]] = counter;
            //    }
            //}
            //int result = -1;
            //foreach (var pair in elementCounts)
            //    if (pair.Value % 2 == 1)
            //        result = pair.Key;
            //return result;

            //PAIR TRACKING
            //List<int> odd = new List<int>();
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    if (odd.Contains(arr[i]))
            //    {
            //        odd.Remove(arr[i]);
            //    }
            //    else
            //    {
            //        odd.Add(arr[i]);
            //    }
            //}
            //return odd[0];

            //LINQ
            //var grouped = arr.GroupBy(a => a);
            //var whered = grouped.Where(e => e.Count() % 2 == 1);
            //var selected = whered.Select(e => e.Key);
            //var singled = selected.Single();
            //return singled;

            //return arr
            //    .GroupBy(a => a)
            //    .Where(e => e.Count() % 2 == 1)
            //    .Select(e => e.Key)
            //    .Single();


            //Linq using Dictionary

            var counts = arr.GroupBy(a => a).ToDictionary(g => g.Key, g => g.Count());
            foreach (var pair in counts)
            {
                if (pair.Value % 2 == 1) return pair.Key;
            }
            return -1;
        }
    }
}
