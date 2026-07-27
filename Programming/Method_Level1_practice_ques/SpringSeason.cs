using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques;

public class SpringSeason
{
    public void solve()
    {
        int month = Convert.ToInt32(Console.ReadLine());
        int day = Convert.ToInt32(Console.ReadLine());

        if(month>=3 && month <= 6)
        {
            if (month == 4 || month == 5) Console.WriteLine("Its a Spring Season");
            else if(month==3 && day<20) Console.WriteLine("Not a spring season");
            else if (month == 6 && day >20) Console.WriteLine("Not a spring season");

        }
        else
        {
            Console.WriteLine("Not a spring season");
        }
    }
}
