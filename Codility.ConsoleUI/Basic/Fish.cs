﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility.ConsoleUI.Basic
{
    /// <summary>
    /// You are given two non-empty arrays A and B consisting of N integers. Arrays A and B represent N voracious fish in a river, ordered
    /// downstream along the flow of the river.
    //    The fish are numbered from 0 to N − 1. If P and Q are two fish and P<Q, then fish P is initially upstream of fish Q.Initially, 
    // each fish has a unique position.
    //    Fish number P is represented by A[P] and B[P]. Array A contains the sizes of the fish.All its elements are unique.Array B contains 
    //  the directions of the fish.It contains only 0s and/or 1s, where:
    //  0 represents a fish flowing upstream,
    //    1 represents a fish flowing downstream.
    //    If two fish move in opposite directions and there are no other (living) fish between them, they will eventually meet each other.Then 
    //  only one fish can stay alive − the larger fish eats the smaller one.More precisely, we say that two fish P and Q meet each other when 
    //  P<Q, 
    //    B[P] = 1 and B[Q] = 0, and there are no living fish between them. After they meet:
    //  If A[P] > A[Q] then P eats Q, and P will still be flowing downstream,
    //  If A[Q] > A[P] then Q eats P, and Q will still be flowing upstream.
    //  We assume that all the fish are flowing at the same speed. That is, fish moving in the same direction never meet.The goal is to 
    // calculate the number of fish that will stay alive.
    //  For example, consider arrays A and B such that:
    //    A[0] = 4    B[0] = 0
    //    A[1] = 3    B[1] = 1
    //    A[2] = 2    B[2] = 0
    //    A[3] = 1    B[3] = 0
    //    A[4] = 5    B[4] = 0
    //  Initially all the fish are alive and all except fish number 1 are moving upstream.Fish number 1 meets fish number 2 and eats it, then it meets fish number 3 and eats it too. Finally, it meets fish number 4 and is eaten by it.The remaining two fish, number 0 and 4, never meet and therefore stay alive.
    //  Write a function:
    //  class Solution { public int solution(int[] A, int[] B); }
    //    that, given two non-empty arrays A and B consisting of N integers, returns the number of fish that will stay alive.
    //    For example, given the arrays shown above, the function should return 2, as explained above.
    /// </summary>
    class Fish
    {
        public static int Solution(int[] A, int[] B)
        {
            //To hold the fish which goes downstream
            Stack<int> value = new Stack<int>();
            int numOfAlives = A.Length;

            for (int i = 0; i < A.Length; i++)
            {
                if (B[i] == 1)
                {
                    value.Push(A[i]);
                }
                if (B[i] == 0)
                {
                    while (value.Count != 0)
                    {
                        if (value.Peek() > A[i])//Eliminate fish if last added 1 is bigger
                        {
                            numOfAlives--;
                            break; //To break the loop and proceed to next 0 fish
                        }
                        else if (value.Peek() < A[i])//If any fish is bigger than '1', it eats the '1'
                        {
                            numOfAlives--;
                            value.Pop();
                        }
                    }
                }
            }
            return numOfAlives;
        }
    }
}
