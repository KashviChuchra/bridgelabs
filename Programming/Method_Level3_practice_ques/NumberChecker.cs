using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level3_Practice_ques;

public class NumberChecker
{
    public int count(int num)
    {
        int temp = num;
        int count = 0;
        while (temp != 0)
        {
            count++;
            temp = temp / 10;
        }
        return count;
    }
    public int[] storeInArray(int num, int length)
    {
        int[] res = new int[length];
        int temp = num;
        int i = 0;
        while (temp != 0)
        {
            res[i] = temp % 10;
            temp = temp / 10;
            i++;
        }
        return res;
    }
    public bool duckNumber(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == 0) return false;
        }
        return true;
    }

    public bool Armstrong(int num, int length)
    {
        double sum = 0;
        int temp = num;
        while (temp != 0)
        {
            int digit = temp % 10;
            sum += Math.Pow(digit, length);
            temp = temp / 10;

        }
        if (sum == num) return true;
        return false;
    }

    public int largest(out int second_largest, int[] arr)
    {
        Array.Sort(arr);
        second_largest = arr[arr.Length - 2];
        return arr[arr.Length - 1];
    }
    public int smallest(out int second_largest, int[] arr)
    {
        second_largest = arr[1];
        return arr[0];
    }
    public void Solve()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        int length=count(num);
        int[] arr=storeInArray(num,length);
        bool duck_num = duckNumber(arr);
        bool armstrong_num = Armstrong(num, length);
        int second_largest = Int32.MinValue;
        int largest_num = largest(out second_largest, arr);
        int second_smallest = Int32.MaxValue;
        int smallest_num = smallest(out second_smallest, arr);

    }
    
}
