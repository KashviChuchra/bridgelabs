using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{

    internal class CalculateTrigonometricFunctions
    {
        public void solve()
        {
            double degrees = 45.0;
            double radians = degrees * (Math.PI / 180.0);

            double sineValue = Math.Sin(radians);
            double cosineValue = Math.Cos(radians);
            double tangentValue = Math.Tan(radians);

            Console.WriteLine($"Angle in Degrees: {degrees}°");
            Console.WriteLine($"Angle in Radians: {radians:F4}");
            Console.WriteLine($"Sine:             {sineValue:F4}");
            Console.WriteLine($"Cosine:           {cosineValue:F4}");
            Console.WriteLine($"Tangent:          {tangentValue:F4}");
        }
    }
}
//12.Write a program to calculate various trigonometric functions using Math class given an angle in degrees
//Hint => 
//Method to calculate various trigonometric functions, Firstly convert to radians and then use Math function to find sine, cosine and tangent.
