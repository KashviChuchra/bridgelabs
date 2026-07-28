using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class ToggleCharacter
    {
        public string solve(String str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    char.ToUpper(str[i]);
                }
                else
                {
                    char.ToLower(str[i]);
                }
            }
            return str;
        }
    }
}
