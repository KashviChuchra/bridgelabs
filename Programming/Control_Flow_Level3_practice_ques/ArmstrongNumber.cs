using System;

namespace control_flow_level3;

class ArmstrongNumber
{
    public void CheckArmstrong()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine()!);

        int originalNumber = num;
        int temp = num;
        int count = 0;
        int sum = 0;
        if (temp == 0)
        {
            count = 1;
        }
        else
        {
            while (temp != 0)
            {
                count++;
                temp /= 10;
            }
        }
        temp = num;

        while (temp != 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, count);
            temp /= 10;
        }

        if (num == 0)
        {
            sum = 0;
        }
        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong Number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong Number.");
        }
    }
}