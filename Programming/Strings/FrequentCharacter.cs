using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class FrequentCharacter
    {
        public char solve(string s)
        {
            char[] str = s.ToCharArray();
            int[] freq= new int[26];

            for(int i=1;i<=str.Length;i++)
            {
                freq[str[i] - 'a']++;
            }

            int max_freq = 0;
            char ch = 'a';
            for (int i = 1; i <= str.Length; i++)
            {
                if (freq[str[i]] > max_freq)
                {
                    max_freq = freq[str[i]];
                    ch = str[i];
                }

            }
            return ch;
            

        }
    }
}
