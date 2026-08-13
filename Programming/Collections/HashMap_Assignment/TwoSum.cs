using System;
using System.Collections.Generic;
using System.Text;

namespace HashMap_Assignment
{
    internal class TwoSum
    {
        public int[] Twosum(int[] nums, int target)
        {
            int[] res = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(target - nums[i]))
                {
                    res[0] = i;
                    res[1] = map[target - nums[i]];
                    return res;
                }
                else map.TryAdd(nums[i], i);
                // if this no is already in dictionary it will skip it
            }
            return res;
        }
    }
}
