using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class MeanHeight
{
    public void CalculateMeanHeightOfPlayers()
    {
        double[] height = new double[11];
        double total = 0;

        for (int i = 0; i < 11; i++)
        {
            height[i] = double.Parse(Console.ReadLine());
            total+= height[i];

        }
        double meanHeight = total / 11;
        Console.WriteLine($"Mean height: {meanHeight}");
    }
}
