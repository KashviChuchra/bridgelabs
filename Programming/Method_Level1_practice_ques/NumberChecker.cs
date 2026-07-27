using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques;

public class NumberChecker
{
    public int solve()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num < 0) return -1;
        else if (num >= 1) return 1;
        else return 0;

    }
}
