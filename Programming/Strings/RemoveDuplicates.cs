using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class RemoveDuplicates
    {
        public String solve(string s)
        {
            int[] freq = new int[26];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                freq[s[i]]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[s[i]] > 1)
                {
                    sb.Append(s);
                }
            }
            return sb.ToString();
        }
    }
}
