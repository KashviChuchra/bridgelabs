using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{
    internal class FindSmallestAndLargest
    {
        public int[] solve(int num1, int num2, int num3)
        {
            int[] res = new int[2];
            if (num1 >= num2 && num1 >= num3)
            {
                res[0] = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                res[0] = num2;
            }
            else
            {
                res[0] = num3;
            }

            if(num1<=num2 && num1 <= num3)
            {
                res[1] = num1;
            }
            else if(num2<=num1 && num2 <= num3)
            {
                res[1] = num2;
            }
            else
            {
                res[1] = num3;
            }
            
            return res;
        }
    }
}
