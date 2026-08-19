using System;
using System.Collections.Generic;
using System.Text;

namespace Searching.Binary_Search
{
    internal class PeakElement
    {
        public int func(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] > nums[mid + 1]) right = mid;
                else left = mid + 1;

            }
            return left;
        }
    }
}
