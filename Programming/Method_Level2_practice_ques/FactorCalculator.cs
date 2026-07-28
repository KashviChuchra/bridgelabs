using System;

namespace Method_Level1_Practice_Ques
{
    internal class FactorCalculator
    {
        public void solve()
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] factors = FindFactors(n);

            for (int i = 0; i < factors.Length; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(FindSum(factors));
            Console.WriteLine(FindProduct(factors));
            Console.WriteLine(FindSumOfSquares(factors));
        }

        public static int[] FindFactors(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            int[] arr = new int[count];
            int idx = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    arr[idx] = i;
                    idx++;
                }
            }
            return arr;
        }

        public int FindSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public long FindProduct(int[] arr)
        {
            long prod = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                prod *= arr[i];
            }
            return prod;
        }

        public double FindSumOfSquares(int[] arr)
        {
            double sumSq = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sumSq += Math.Pow(arr[i], 2);
            }
            return sumSq;
        }
    }
}
