using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    /// <summary>
    /// Find the centure from a given year between 1 and 3000
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// //1700 -> 17  1792 -! 18
    /// </summary>
    public static class CenturyFromYear
    {
        public static int Solution(int year)
        {
            return year / 100 + ((year % 100) == 0 ? 0 : 1);
        }
    }
}
