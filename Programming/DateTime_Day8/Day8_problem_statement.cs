using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day_date_functions
{
    internal class Day8_problem_statement
    {
        public void func()
        {
            Random rand= new Random();
            int num=rand.Next(1, 100);
            NumberGuessingGame(num);

            int[] arr = new int[3];
            for(int i=0;i<3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Max of 3 nums: {MaximumNumber(arr)}");
            if (PrimeNumberChecker(7)) Console.WriteLine("Number is Prime");
            else Console.WriteLine("Number is not prime");

            FibonacciSequence(4);
            PalindromeChecker(1234321);
            Console.WriteLine(Factorial(4));

            Console.WriteLine(GCD(4,3));

            
        }
        public void NumberGuessingGame(int key)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            while (num != key)
            {
                if (num == key)
                {
                    Console.WriteLine("Number Found. Yay!");
                    break;
                }
                else if (num > key)
                {
                    Console.WriteLine("Too long!");
                }
                else
                {
                    Console.WriteLine("Too short");
                }
                num=Convert.ToInt32(Console.ReadLine());
            }
            
        }

        public int MaximumNumber(int[] arr)
        {
            int max_num = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max_num){
                    max_num = arr[i];
                }
            }
            return max_num;
        }

        public bool PrimeNumberChecker(int num)
        {
            if (num <= 1) return false;
            for(int i = 2; i < num; i++)
            {
                if(num%i!=0) return false;
            }
            return true;
        }

        public void FibonacciSequence(int num)
        {
            Console.Write("0,1,");
            int a = 0;
            int b = 1;
            for(int i = 2; i < num; i++)
            {
                int c = a + b;
                Console.Write($"{c},");
                a = b;
                b = c;
            }
        }
        public void PalindromeChecker(int num)
        {
            int temp = num;
            int res = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                res += digit;
                temp = temp / 10;
            }
            if (res == temp) Console.WriteLine("Palindrome NUmber");
            else Console.WriteLine("Not Palindrome Number");
        }

        public int Factorial(int num)
        {
            if (num <= 1) return 1;
            return num * Factorial(num - 1);
        }

        public int GCD(int num1, int num2)
        {
            int div = num1;
            while ()
            {

            }
        }
    }
}
