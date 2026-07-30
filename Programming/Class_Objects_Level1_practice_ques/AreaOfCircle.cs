using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Objects_level1
{
    class AreaOfCircle
    {
        private int radius;
        const double pi = 3.14;

        public AreaOfCircle(int radius)
        {
            this.radius = radius;
        }

        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double calculateArea()
        {
            return pi * radius * radius;
        }
        public void displayArea(double area)
        {
            Console.WriteLine($"Area of Circle: {area}");
        }
    }
}
