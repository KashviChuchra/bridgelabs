using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level3_Practice_ques;

public class Player
{
    public int sum(int[] height)
    {
        int total = 0;
        for(int i = 0; i < height.Length; i++)
        {  
            total+= height[i];
        }
        return total;
    }
    public double meanHeight(int total, int num)
    {
        return total*1.0/num;
    }
    public int shortestHeight(int[] height)
    {
        Array.Sort(height);
        return height[0];
    }
    public int tallestHeight(int[] height)
    {
        return height[height.Length-1];
    }

    public void solve()
    {
        int[] height= new int[11];
        for(int i = 0; i < height.Length; i++)
        {
            height[i]=Convert.ToInt32(Console.ReadLine());
        }

        int sum_of_ele=sum(height);
        double mean = meanHeight(sum_of_ele, 11);
        int shortest_height = shortestHeight(height);
        int tallest_height = tallestHeight(height);

        Console.WriteLine($"Sum of elements\t{sum_of_ele}\nMean\t{mean}\nShortest Height\t{shortest_height}\nTallest Height\t{tallest_height}");
    }
}
