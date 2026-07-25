using System;
using System.Collections.Generic;
using System.Text;

namespace control_flow_level3;

public class AbundantNumber
{
    public void CheckAbundantNumber() {
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum > num)
            {
                Console.WriteLine($" {num} is Abundant Number");
            }
            else
            {
                Console.WriteLine($" {num} is not Abundant Number");

            }
        }
    }

}
