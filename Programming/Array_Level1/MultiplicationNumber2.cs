using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class MultiplicationTable2
{
    public void CalculateMuliplicationTable()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine($"{num}*{i}={num * i}");
        }
    }
}
