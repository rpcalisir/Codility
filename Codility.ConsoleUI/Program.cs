using Codility.ConsoleUI.Basic;
using Codility.ConsoleUI.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryOut
            //Console.WriteLine(String.Join(",", TryOut.Solution(new int[] { 1,3,1,4,2,3,5,4},5)));

            //Console.WriteLine(TryOut.Pre(21));

            #region Basic
            //ArrayRotation
            //Console.WriteLine(String.Join(",", ArrayRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3)));

            //DistinctValuesInArray
            //Console.WriteLine(DistinctValuesInArray.Solution(new int[] { 2, 1, 1, 2, 3, 1 }));

            //OddNumberInArray
            //Console.WriteLine(OddNumberInArray.Solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));

            //GenomicRangeQuery
            //Console.WriteLine(GenomicRangeQuery.Solution("CAGCCTA", new int[] { 2,5,0 }, new int[] { 4, 5, 6 }));

            //MaxProductOfThree
            //Console.WriteLine(MaxProductOfThree.Solution(new int[] {-3,2,1,-2,5,6}));

            //MinAvgTwoSlice
            //Console.WriteLine(MinAvgTwoSlice.Solution(new int[] {4,2,2,5,1,5,8}));

            //MostFrequentElement
            //Console.WriteLine(MostFrequentElement.Solution(new int[] {1,2,5,2,4,3,3,2,9 }));

            //NumberOfDiscIntersections
            //Console.WriteLine(NumberOfDiscIntersections.Solution(new int[] {1,5,2,1,4,0}));

            //PassingCars
            //Console.WriteLine(PassingCars.Solution(new int[] {0,1,0,1,1 }));

            //ProperlyNestedString
            Console.WriteLine(ProperlyNestedString.Solution("{[()()]}"));
            #endregion

            #region Challenges

            #endregion

            #region Demo
            //BinaryGap
            //Console.WriteLine(BinaryGap.GapFinder(6));

            //FindMultiplesInRange
            //Console.WriteLine(FindMultiplesInRange.Solution(8, 11, 2));

            //MaxFlavors
            //Console.WriteLine(MaxFlavors.Solution(new int[] {1,2,3,4}, new int[] {3,6,4,4}));

            //MaximumPossibleValue
            //Console.WriteLine(MaximumPossibleValue.Solution(267,5));

            //NumToDigits
            //foreach (var digit in NumToDigits.Solution(213))
            //{
            //    Console.WriteLine(digit);
            //}

            //SmallestNotContained


            //SortArray
            //foreach (var element in SortArray.SortDescending(new int[] {3, 7,6, 8, 4, 9, 5, 2 }))
            //{
            //    Console.WriteLine(element);
            //}
            #endregion

            Console.ReadLine();
        }
    }
}
