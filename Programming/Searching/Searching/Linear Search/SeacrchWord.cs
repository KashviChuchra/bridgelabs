using System;
using System.Collections.Generic;
using System.Text;

namespace Searching.Linear_Search
{
    internal class SeacrchWord
    {
        public void func(string[] str, string word)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (CheckSentence(str[i],word)) {
                    Console.WriteLine($"{word} found in sentence numbered {i + 1}");
                    return;
                }
            }
            Console.WriteLine("Word not found");
        }
        public bool CheckSentence(string str, string word)
        {
            // not efficient way, 
            string s= word.ToLower();
            if (str.Contains(s)) return true;
            return false;
        }
    }
}
