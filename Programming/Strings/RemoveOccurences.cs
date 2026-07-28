using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class RemoveOccurences
    {
        public String solve(String str, char ch)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ch)
                {
                    sb.Append(ch);
                }
            }
            return sb.ToString();
        }
    }
}
