using System;
using System.Collections.Generic;
using System.Text;

namespace control_flow_level3;
class no_of_digits
{
    public void CheckDigits()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int count = 0;

        if (num == 0)
        {
            Console.WriteLine($"The no of digits in {num} is 1");
            return;
        }
        while (temp != 0)
        {
            count++;
            temp = temp / 10;

        }
        Console.WriteLine($"The no of digits in {num} is {count}");
    }
}
