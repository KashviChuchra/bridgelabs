using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{
    public class SumNNumbers
    {
        public int solve()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
