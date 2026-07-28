using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class Palindrome
    {
        public bool solve(String s)
        {
            char[] str = s.ToCharArray();
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                char temp = str[left];
                str[left] = str[right];
                str[right] = temp;
                left++;
                right--;
            }
            String new_str=new string(str);
            return new_str == s;

        }
    }
}
