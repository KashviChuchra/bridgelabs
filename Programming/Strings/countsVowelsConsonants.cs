using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class countsVowelsConsonants
    {
        public void solve(String s)
        {
            int vowelsC = 0;
            int consC = 0;
            String str = s.ToLower();
            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowelsC++;
                }
                else
                {
                    consC++;
                }
            }
            Console.WriteLine($"Vowels:\t{vowelsC}\nConsonants:\t{consC}");
        }
    }
}
