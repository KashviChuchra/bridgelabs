using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Level1;

public class _2Dinto1D
{
    public void Converion()
    {
        int row = Convert.ToInt32(Console.ReadLine());
        int col = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[row, col];
        int[] new_arr = new int[row * col];
        int index = 0;

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                arr[i,j] = Convert.ToInt32(Console.ReadLine());
                new_arr[index]=arr[i,j];
                index++;

            }
        }
        for (int i = 0; i < new_arr.Length; i++)
        {
            Console.Write(new_arr[i] + " ");
        }
     }

    }
