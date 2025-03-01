﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    /// <summary>
    /// Ratiorg got statues of different sizes as a present from CodeMaster for his birthday, each statue having an non-negative integer size. 
    /// Since he likes to make things perfect, he wants to arrange them from smallest to largest so that each statue will be bigger than the 
    /// previous one exactly by 1. He may need some additional statues to be able to accomplish that. Help him figure out the minimum number
    /// of additional statues needed.
    ///Example
    ///For statues = [6, 2, 3, 8], the output should be
    ///makeArrayConsecutive2(statues) = 3.
    ///Ratiorg needs statues of sizes 4, 5 and 7.
    ///
    /// 
    /// </summary>
    public static class MakeArrayConsecutive2
    {
        public static int Solution(int[] statues)
        {
            Array.Sort(statues);
            int diff = 0;
            int necessary = 0;

            for (int i = 1; i < statues.Length; i++)
            {
                diff = statues[i] - statues[i - 1];
                if (diff != 1)
                {
                    necessary += (diff - 1);
                }
            }
            return necessary;
        }
    }
}
