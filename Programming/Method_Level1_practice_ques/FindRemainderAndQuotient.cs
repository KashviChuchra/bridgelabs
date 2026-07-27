using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{
    internal class FindRemainderAndQuotient
    {
        public int[] solve(int num, int div)
        {
            int[] res = new int[2];
            res[0] = num/div;
            res[1] = num%div;
            return res;
        }
    }
}
