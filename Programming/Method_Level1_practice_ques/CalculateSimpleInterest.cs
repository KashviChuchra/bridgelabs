using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques;

public class CalculateSimpleInterest
{
    public double solve()
    {
        double p = double.Parse(Console.ReadLine());
        double r = double.Parse(Console.ReadLine());
        double t = double.Parse(Console.ReadLine());

        double si = p * r * t / 100;
        Console.WriteLine($"S.I: {si}");
        return si;
    }


}
