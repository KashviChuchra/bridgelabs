using Searching.Binary_Search;
using Searching.Linear_Search;
using System;
namespace Searching;

class Program
{
    public static void Main(string[] args)
    {
        // linear search
        int[] arr = new int[] { 4, 5, -2, 8, -3 };
        FirstNegativeNumber obj = new FirstNegativeNumber();
        obj.func(arr);

        string[] str = new string[] { "Apple is a fruit.", "I like bananas." };
        string target = "apple";
        SeacrchWord obj1 = new SeacrchWord();
        obj1.func(str, target);


        // binary search 
        int[] nums = new int[] { 1, 2, 1, 3, 5, 6, 4 };
        PeakElement obj2 = new PeakElement();
        Console.WriteLine("Peak Element: " + obj2.func(nums));

        FirstAndLastOccurence obj3 = new FirstAndLastOccurence();
        int[] arr1 = new int[] { 5, 7, 7, 8, 8, 10 };
        int targetElement = 8;
        int[] res = obj3.SearchRange(arr1, targetElement);
        Console.WriteLine(res[0] + " " + res[1]);

        RotationPoint obj4 = new RotationPoint();
        int[] arr2 = new int[] { 4, 5, 6, 7, 0, 1, 2 };
        Console.WriteLine($"Rotation Point: {obj4.func(arr2)}");


        // Challenge Problem
        ChallengeProblem obj6= new ChallengeProblem();
        List<int> list = new List<int> { 3, 4, -1, 1, 8 };
        int targetE = 4;
        obj6.FindMissingPositiveNum(list);
        
        Console.WriteLine($"Target element: {obj6.FindTarget(list, targetE)}");

            
    }
}