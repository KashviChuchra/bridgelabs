using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class Anagrams
    {
        public bool solve(String str1, String str2)
        {
            char[] ch1 = str1.ToCharArray();
            char[] ch2 = str2.ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            return ch1 == ch2;
        }
    }
}
