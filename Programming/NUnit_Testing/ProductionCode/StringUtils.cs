using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace ProductionCode
{
    public class StringUtils
    {
//        Reverse(string str) : Returns the reverse of a given string.
//IsPalindrome(string str) : Returns true if the string is a palindrome.
//ToUpperCase(string str): Converts a string to uppercase.

        public string Reverse(string s)
        {
            char[] str = s.ToCharArray();
            int left = 0;
            int right = str.Length - 1;
            while (left < right)
            {
                char temp= str[left];
                str[left]= str[right];
                str[right] = temp;

                left++;
                right--;
            }
            return str.ToString();
        }

        public bool IsPalindrome(string s)
        {
            string str = Reverse(s);
            if (str == s) return true;
            return false;
        }

        public string ToUpperCase(string s)
        {
            char[] str = s.ToCharArray();
            for(int i=0;i<str.Length; i++)
            {
                str[i] = (char)(str[i] - ('a' - 'A'));
            }
            return str.ToString();
        }
        // string s=""; s[i]=x cant do this, its read only value

    }
}
