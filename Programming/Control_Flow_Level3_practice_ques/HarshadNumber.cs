using System;
using System.Collections.Generic;
using System.Text;

namespace control_flow_level3;

public class HarshadNumber
{
    public void CheckHarshadNumber()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int sum = 0;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp = temp / 10;
        }
        if (num % sum == 0)
        {
            Console.WriteLine($"{num} is a Harshad Number");
        } 
        else{
            Console.WriteLine($"{num} is not a Harshad Number");

        }


    }

}
