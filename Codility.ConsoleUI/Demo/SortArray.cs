using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Demo
{
    public static class SortArray
    {
        public static int[] SortDescending(int[] arr)
        {
            //Bubble Sort
            //int temp;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr.Length-1; j++)
            //    {
            //        if (arr[j]<arr[j+1])
            //        {
            //            temp = arr[j + 1];
            //            arr[j + 1] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //return arr;

            //linq
            return arr.OrderByDescending(x => x).ToArray();

            //.Net
            //Array.Sort(arr);//Ascending
            //Array.Reverse(arr);
            //return arr;

        }
        public static int[] SortAscending(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
}
