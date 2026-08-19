using System;
using System.Collections.Generic;
using System.Text;

namespace Searching.Linear_Search
{
    internal class FirstNegativeNumber
    {
        public void func(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    Console.WriteLine($"First Negative Number: {arr[i]}");
                    return;
                }
            }
            Console.WriteLine("No negative Number present!");
        }
    }
}
