using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class MultiplicationTable
{
    public void CalculateMuliplicationTable()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{num}*{i}={num * i}");
        }
    }
}
