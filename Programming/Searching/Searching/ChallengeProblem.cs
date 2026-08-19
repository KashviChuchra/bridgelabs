using System;
using System.Collections.Generic;
using System.Text;

namespace Searching
{
    internal class ChallengeProblem
    {
        public void FindMissingPositiveNum(List<int> list)
        {
            HashSet<int> set = new HashSet<int>(list);
            int missing = 1;
            while (set.Contains(missing))
            {
                missing++;
            }

            Console.WriteLine($"Missing Positive Number: {missing}");
        }

        public int FindTarget(List<int> list, int target)
        {
            list.Sort();
            int left = 0;
            int right = list.Count - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (list[mid] == target)
                {
                    return mid;
                }
                else if (list[mid] > target)
                {
                    right = mid - 1;

                }
                else
                {
                    left = mid + 1;

                }
            }
            return -1;
        }
    }
}
