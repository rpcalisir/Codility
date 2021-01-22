using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// A small frog wants to get to the other side of a river. The frog is initially located on one bank of the river
    /// (position 0) and wants to get to the opposite bank (position X+1). Leaves fall from a tree onto the surface of the river.
    //   You are given an array A consisting of N integers representing the falling leaves.A[K] represents the position where one
    //  leaf falls at time K, measured in seconds.
    //  The goal is to find the earliest time when the frog can jump to the other side of the river.The frog can cross only when
    //  leaves appear at every position across the river from 1 to X (that is, we want to find the earliest moment when all the
    //  positions from 1 to X are covered by leaves). You may assume that the speed of the current in the river is negligibly 
    //  small, i.e.the leaves do not change their positions once they fall in the river.
    //  For example, you are given integer X = 5 and array A such that:
    //    A[0] = 1
    //    A[1] = 3
    //    A[2] = 1
    //    A[3] = 4
    //    A[4] = 2
    //    A[5] = 3
    //    A[6] = 5
    //    A[7] = 4
    //  In second 6, a leaf falls into position 5. This is the earliest time when leaves appear in every position across the river.
    //  Write a function:
    //class Solution { public int solution(int X, int[] A); }
    //    that, given a non-empty array A consisting of N integers and integer X, returns the earliest time when the frog can jump to the other side of the river.
    //    If the frog is never able to jump to the other side of the river, the function should return −1.
    //For example, given X = 5 and array A such that:
    //  A[0] = 1
    //  A[1] = 3
    //  A[2] = 1
    //  A[3] = 4
    //  A[4] = 2
    //  A[5] = 3
    //  A[6] = 5
    //  A[7] = 4
    //the function should return 6, as explained above.
    /// </summary>
    public class FrogRiverOne
    {
        /// <summary>
        /// Second Pos
        /// A[0]  = 1
        /// A[1]  = 3
        /// A[2]  = 1
        /// A[3]  = 4
        /// A[4]  = 2
        /// A[5]  = 3
        /// A[6]  = 5
        /// A[7]  = 4
        /// 
        /// if d[A[i]==0]
        ///     d[A[i]]= A[i]
        ///     c++
        /// 
        /// i=0 d[A[0]] == 0 => d[1] = A[0] = 1  c=1       1.pozisyona 0.saniyede düştü
        /// i=1 d[A[1]] == 0 => d[3] = A[1] = 3  c=2       3.pozisyona 1. saniyede düştü
        /// i=2 d[A[2]] == 0 => d[1] != 0                  1.pozisyona 2. saniyede tekrar düştü, fakat bu pozisyona zaten düşmüştü, yani sadece saniye arttı
        /// i=3 d[A[3]] == 0 => d[4] = A[3] = 4  c=3       3. saniyede, 4.pozisyona düştü
        /// i=4 d[A[4]] == 0 => d[2] = A[4] = 2  c=4       4. saniyede, 2. pozisyona düştü
        /// i=5 d[A[5]] == 0 => d[3] != 0                  5. saniyede, 3. pozisyona tekrar düştü, fakat önceden düşmüştü
        /// i=6 d[A[6]] == 0 => d[5] = A[6] = 5  c=5 //6. saniyede, pozisyon 5'e düşer, pozisyon 5'e daha önce düşmediyse pozisyonu doldur ve zıplamayı arttır
        /// i=7 d[A[7]] == 0 
        /// 
        /// d[2] means pos 2, A[4] means leave falls to pos 2 at 4. second 
        /// 
        /// A[i]'deki i, saniye demektir
        /// A[0] = 1; ilk başta 1. pozisyonda yaprak var demek
        /// A[1] = 3; 1. saniyede 3. pozisyonda yaprak var demek
        /// 
        /// position dizisi;
        /// i= 0 d[A[i]] demek, d[A[0]] => d[1] = A[0] = 1 demek ilk başta 1.pozisyonda yaprak vardı
        /// i= 1 d[A[i]] demek, d[A[1]] => d[3] = A[1] = 3 demek 3.pozisyona ilk defa 1.saniyede düştü demek(A[1]'in içindeki 1)
        /// i= 2 d[A[i]] demek, d[A[2]] => d[1] = A[2] = 1 demek 1. pozisyona 2. saniyede tekrar düştü, fakat daha önce düşmüştü ve zıplanmıştı.
        /// i= 3 d[A[i]] demek, d[A[3]] => d[4] = A[3] = 3 demek 3. saniyede 4. pozisyona düştü, bu pozisyon boşsa ilk defa düşmüştür, zıpla
        /// </summary>
        /// <param name="X"></param>
        /// <param name="A"></param>
        /// <returns></returns>
        public static int Solution(int X, int[] A)
        {
            int jump = 0;
            int[] destinationPos = new int[X + 1];

            for (int i = 0; i < A.Length; i++)
            {
                if (destinationPos[A[i]] == 0)
                {
                    destinationPos[A[i]] = A[i];
                    jump++;
                }
                if (jump == X)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
