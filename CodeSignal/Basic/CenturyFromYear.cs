using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSignal.Basic
{
    public static class CenturyFromYear
    {
        public static int Solution(int year)
        {
            return year / 100 + ((year % 100) == 0 ? 0 : 1);
        }
    }
}
