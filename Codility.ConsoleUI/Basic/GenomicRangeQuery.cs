using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A DNA sequence can be represented as a string consisting of the letters A, C, G and T, which correspond to the types of 
    /// successive nucleotides in the sequence. Each nucleotide has an impact factor, which is an integer. Nucleotides of types 
    /// A, C, G and T have impact factors of 1, 2, 3 and 4, respectively. You are going to answer several queries of the form: 
    /// What is the minimal impact factor of nucleotides contained in a particular part of the given DNA sequence?
    ///    The DNA sequence is given as a non-empty string S = S[0]S[1]...S[N - 1] consisting of N characters.There are M queries,
    /// which are given in non-empty arrays P and Q, each consisting of M integers.The K-th query(0 ≤ K<M) requires you to find the minimal impact factor of nucleotides contained in the DNA sequence between positions P[K] and Q[K] (inclusive).
    //For example, consider string S = CAGCCTA and arrays P, Q such that:
    //    P[0] = 2    Q[0] = 4
    //    P[1] = 5    Q[1] = 5
    //    P[2] = 0    Q[2] = 6
    //The answers to these M = 3 queries are as follows:
    //The part of the DNA between positions 2 and 4 contains nucleotides G and C(twice), whose impact factors are 3 and 2 respectively,
    //so the answer is 2.
    //The part between positions 5 and 5 contains a single nucleotide T, whose impact factor is 4, so the answer is 4.
    //The part between positions 0 and 6 (the whole string) contains all nucleotides, in particular nucleotide A whose impact factor is
    //1, so the answer is 1.
    //Write a function:
    //class Solution { public int[] solution(string S, int[] P, int[] Q); }
    //    that, given a non-empty string S consisting of N characters and two non-empty arrays P and Q consisting of M integers, 
    //returns an array consisting of M integers specifying the consecutive answers to all queries.
    //    Result array should be returned as an array of integers.
    //    For example, given the string S = CAGCCTA and arrays P, Q such that:
    //        P[0] = 2    Q[0] = 4
    //        P[1] = 5    Q[1] = 5
    //        P[2] = 0    Q[2] = 6
    //    the function should return the values [2, 4, 1], as explained above.
    /// </summary>
    public class GenomicRangeQuery
    {
        public static int[] Solution(string S, int[] P, int[] Q)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            List<int> minimals = new List<int>();
            int min = int.MaxValue;
            for (int i = 0; i < P.Length; i++)
            {
                int impactFactor;
                for (int a = P[i]; a <= Q[i]; a++)
                {
                    impactFactor = GetImpactFactor(S[a]);
                    if (impactFactor < min)
                        min = impactFactor;
                }
                minimals.Add(min);
                min = int.MaxValue;
            }
            return minimals.ToArray();
        }
        private static int GetImpactFactor(char nuc)
        {
            int result = 0;
            switch (nuc)
            {
                case 'A':
                    result = 1;
                    break;
                case 'C':
                    result = 2;
                    break;
                case 'G':
                    result = 3;
                    break;
                case 'T':
                    result = 4;
                    break;
            }
            return result;
        }
    }
}
