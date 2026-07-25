using Array_level1;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Array_Level1;

public  class NumberFunction
{
    public void checkNumber()
    {

        int[] arr = new int[5];
        for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i< arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                Console.Write("Number is Positive ");
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine($"{arr[i]} is even");
                }
                else
                {
                    Console.WriteLine($"{arr[i]} is odd");
                }
            }
            else if (arr[i] < 0)
            {

                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }
        }
        bool check = arr[0] > arr[arr.Length - 1];
        if (arr[0] == arr[arr.Length - 1])
        {
            Console.WriteLine("Both Numbers are equal");
        }
        else if(true)
        {
            Console.WriteLine("First ele is greater");
        }
        else
        {
            Console.WriteLine("Second ele is greater");

        }
    }
}
