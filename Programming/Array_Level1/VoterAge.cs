using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class VoterAge
{
    public void checkVoterAge()
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            if (arr[i] < 0)
            {
                Console.WriteLine("Invalid Age. Re-enter age: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 18)
            {
                Console.WriteLine($"The student with the age {arr[i]} can vote");
            }
            else
            {
                Console.WriteLine($"The student with the age {arr[i]} can not vote");


            }
        }

    }
}
