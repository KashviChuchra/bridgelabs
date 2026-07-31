using System;
using System.Collections.Generic;
using System.Text;

namespace class_objects2
{
    class Circle
    {
        public int Radius { get; set; }
        public Circle()
        {
            Radius = 0;
        }
        public Circle(int rad) : this()
        {
            Radius = rad;
        }
        public void area()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"Circle: {3.14 * Radius * Radius}");
        }
    }
 }
