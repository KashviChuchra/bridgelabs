using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class reverse
    {
        public String solve(String s)
        {
            char[] str = s.ToCharArray();
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                char temp= str[left];
                str[left] = str[right];
                str[right] = temp;
                left++;
                right--;
            }
            return new string(str);
        }
    }
}
