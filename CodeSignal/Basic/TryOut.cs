using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    public static class TryOut
    {
        public static int Solution(int[] statues)
        {
            int diff, necessary = 0;
            Array.Sort(statues);

            for (int i = 1; i < statues.Length; i++)
            {
                diff = statues[i] - statues[i - 1];
                if (diff!=1)
                {
                    necessary += (diff - 1);
                }
            }
            return necessary;
        }
    }
}
