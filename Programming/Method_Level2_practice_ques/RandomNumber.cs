using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace Method_Level2_Practice_Ques;

public class RandomNumber
{
    public int[] Generate4DigitRandomArray(int n)
    {
        int[] numbers = new int[n];
        Random rand = new Random();

        for (int i = 0; i < n; i++)
        {
            numbers[i] = rand.Next(1000, 10000);
        }
        return numbers;
    }

    public double[] FindAverageMinMax(int[] numbers)
    {
        int totalSum = 0;
        int minVal = numbers[0];
        int maxVal = numbers[0];

        for (int i = 0; i < numbers.Length; i++)
        {
            totalSum += numbers[i];
            minVal = Math.Min(minVal, numbers[i]);
            maxVal = Math.Max(maxVal, numbers[i]);
        }

        double average = (double)totalSum / numbers.Length;
        return new double[] { average, minVal, maxVal };
    }
    public void solve()
    {

        int[] arr = Generate4DigitRandomArray(5);
        Console.WriteLine("Generated 4-digit numbers: " + string.Join(", ", arr));

        double[] stats = FindAverageMinMax(arr);
        Console.WriteLine($"Average Value: {stats[0]:F2}");
        Console.WriteLine($"Minimum Value: {stats[1]}");
        Console.WriteLine($"Maximum Value: {stats[2]}");

    }
}