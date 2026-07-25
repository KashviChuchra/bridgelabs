using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class NumberFunction2
{
    public void checkNumber()
    {
        double total = 0;
        int index = 0;
        double[] arr = new double[10];
        while (true)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num <= 0 || index == 10)
            {
                break;
            }
            arr[index] = num;
            index++;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            total += arr[i];
        }
        Console.WriteLine(total);
    }
}
