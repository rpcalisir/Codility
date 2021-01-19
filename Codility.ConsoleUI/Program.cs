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
            //GapFinder
            //Console.WriteLine(BinaryGap.GapFinder(6));

            //MaxFlavors
            //Console.WriteLine(MaxFlavors.Solution(new int[] {1,2,3,4}, new int[] {3,6,4,4}));

            //NumberToDigits
            //foreach (var digit in NumToDigits.Solution(213))
            //{
            //    Console.WriteLine(digit);
            //}

            //GenerateBiggestNumber
            //Console.WriteLine(GenerateBiggestNumber.Solution(623,5));

            //SortArray
            //foreach (var element in SortArray.SortDescending(new int[] {3, 7,6, 8, 4, 9, 5, 2 }))
            //{
            //    Console.WriteLine(element);
            //}

            //TryOut
            foreach (var item in TryOut.MutateTheArray(5, new int[] { 4, 0, 1, -2, 3 }))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(TryOut.MutateTheArray(1, new int[] {9}));

            //GenerateBiggestNumber
            //Console.WriteLine(GenerateBiggestNumber.Solution(-999,4));


            Console.ReadLine();
        }
    }
}
