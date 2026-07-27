using System;
using System.Collections.Generic;
using System.Text;

namespace Method_Level1_Practice_Ques
{
    internal class Chocolates
    {
        public void solve()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            int m=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Chocolates each student gets: {n / m}");
            Console.WriteLine($"Remaining Chocolates: {n % m}");

        }
    }
}
