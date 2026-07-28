using System;
using System.Collections.Generic;
using System.Text;

namespace Strings
{
    internal class CompareString
    {
        public void solve(string s1, string s2)
        {
            int len = Math.Min(s1.Length, s2.Length);
            for (int i = 0; i < len; i++)
            {
                int ch1= s1[i]-'a';
                int ch2 = s2[i] - 'a';

                if (ch1 > ch2)
                {
                    Console.WriteLine($"{s1} comes before {s2} in lexiographical order");
                    return;
                }
                else {
                    Console.WriteLine($"{s2} comes before {s1} in lexiographical order");
                    return;
                }

            }
            if (s1.Length == s2.Length) Console.WriteLine("Both are equal in lexiographical order");
            else if(s1.Length>s2.Length) Console.WriteLine($"{s2} comes before {s1} in lexiographical order");
            else
            {
                Console.WriteLine($"{s1} comes before {s2} in lexiographical order");
            }

        }
    }
}
