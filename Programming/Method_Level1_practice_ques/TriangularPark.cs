using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques;

public class TriangularPark
{
    public double solve(int distance)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c= Convert.ToInt32(Console.ReadLine());

        double round=distance*0.1/(a+b+c);
        return round;

    }
}
