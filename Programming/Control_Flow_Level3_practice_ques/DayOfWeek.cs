using System;
using System.Collections.Generic;
using System.Text;

namespace control_flow_level3;

public class DayOfWeek
{
    public void CheckDayOfWeek()
    {
        Console.WriteLine("\"Enter day, Month, Year");
        int month = Convert.ToInt32(Console.ReadLine());
        if(month<1 || month > 12)
        {
            Console.WriteLine("Invalid Month. Kindly re-enter");
            month= Convert.ToInt32(Console.ReadLine());
        }
        int day = Convert.ToInt32(Console.ReadLine());
        if (day < 1 || day > 31 || (month==2 && day>28))
        {
            Console.WriteLine("Invalid day. Kindly re-enter");
            day = Convert.ToInt32(Console.ReadLine());
        }
        int year = Convert.ToInt32(Console.ReadLine());

        int y0 = year - (14 -month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + 31 * m0 / 12) % 7;

        Console.WriteLine(d0);


    }
}
