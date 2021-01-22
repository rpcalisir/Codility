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
            Console.WriteLine(String.Join(",", TryOut.Solution(new int[] { 1,3,1,4,2,3,5,4},5)));

            //Console.WriteLine(TryOut.Pre(21));

            #region Basic
            //ArrayRotation
            //Console.WriteLine(String.Join(",", ArrayRotation.Solution(new int[] { 3, 8, 9, 7, 6 }, 3)));

            //OddNumberInArray
            //Console.WriteLine(OddNumberInArray.Solution(new int[] { 9, 3, 9, 3, 9, 7, 9 }));
            #endregion

            #region Demo
            //BinaryGap
            //Console.WriteLine(BinaryGap.GapFinder(6));

            //MaxFlavors
            //Console.WriteLine(MaxFlavors.Solution(new int[] {1,2,3,4}, new int[] {3,6,4,4}));

            //MaximumPossibleValue
            //Console.WriteLine(MaximumPossibleValue.Solution(623,5));

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
