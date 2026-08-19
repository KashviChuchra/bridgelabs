using System;
using System.Collections.Generic;
using System.Text;

namespace Searching.Binary_Search
{
    internal class FirstAndLastOccurence
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] res = new int[2];
            res[0] = FirstPosition(nums, target);
            res[1] = LastPosition(nums, target);
            return res;
        }
        public int FirstPosition(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    index = mid;
                    right = mid - 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return index;
        }
        public int LastPosition(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target)
                {
                    index = mid;
                    left = mid + 1;
                }
                else if (nums[mid] > target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return index;
        }
    }
}
