using System;

namespace Method_Level1_Practice_Ques
{
    internal class ArrayMethodChecker
    {
        public void solve()
        {
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPositive(arr[i]))
                {
                    if (IsEven(arr[i]))
                    {
                        Console.WriteLine("Positive Even");
                    }
                    else
                    {
                        Console.WriteLine("Positive Odd");
                    }
                }
                else
                {
                    Console.WriteLine("Negative");
                }
            }

            int res = Compare(arr, arr[arr.Length - 1]);

            if (res == 1)
            {
                Console.WriteLine("Greater");
            }
            else if (res == 0)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Less");
            }
        }

        public bool IsPositive(int n)
        {
            return n >= 0;
        }

        public bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public int Compare(int n1, int n2)
        {
            if (n1 > n2)
            {
                return 1;
            }
            else if (n1 == n2)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
