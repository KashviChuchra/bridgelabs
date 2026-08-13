using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap_Assignment
{
    internal class ZeroFilledSubArray
    {
        public long ZeroFilledSubarray(int[] nums)
        {
            int zero = 0;
            long result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    result += zero + 1;
                    zero++;

                }
                else
                {
                    zero = 0;
                }

            }
            return result;
        }
    }
}
