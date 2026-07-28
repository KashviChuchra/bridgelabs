using System;

namespace Method_Level1_Practice_Ques
{
    internal class MathFunction
    {
        public void solve()
        {
            double a = 1;
            double b = -5;
            double c = 6;

            double[] roots = FindRoots(a, b, c);

            if (roots.Length == 0)
            {
                Console.WriteLine("No real roots.");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"One root: {roots[0]}");
            }
            else
            {
                Console.WriteLine($"Two roots: {roots[0]} and {roots[1]}");
            }
        }

        public double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);

            if (delta < 0)
            {
                return new double[0];
            }
            else if (delta == 0)
            {
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
        }
    }
}
