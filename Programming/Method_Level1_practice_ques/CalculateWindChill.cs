using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{
    internal class CalculateWindChill
    {
        public double solve(double temp, double windSpeed)
        {
            return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * windSpeed * 0.1;
        }
    }
}
