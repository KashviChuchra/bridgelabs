using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level3_Practice_ques;

internal class MatrixFunctions
{
    public void solve()
    {
        int rows1 = Convert.ToInt32(Console.ReadLine());
        int cols1 = Convert.ToInt32(Console.ReadLine());
        int[,] mat1 = new int[rows1, cols1];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                mat1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        int rows2 = Convert.ToInt32(Console.ReadLine());
        int cols2 = Convert.ToInt32(Console.ReadLine());
        int[,] mat2 = new int[rows2, cols2];

        for (int i = 0; i < rows2; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                mat2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        if (rows1 == rows2 && cols1 == cols2)
        {
            addMatrix(mat1, mat2);
            subMatrix(mat1, mat2);
        }
        if (cols1 == rows2)
        {
            multiplyMatrix(mat1, mat2);

        }
    }
    public void addMatrix(int[,] mat1, int[,] mat2)
    {
        int[,] res = new int[mat1.GetLength(0), mat1.GetLength(1)];

        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                res[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        display(res, res.GetLength(0), res.GetLength(1));
    }

    public void subMatrix(int[,] mat1, int[,] mat2)
    {
        int[,] res = new int[mat1.GetLength(0), mat1.GetLength(1)];

        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                res[i, j] = mat1[i, j] - mat2[i, j];
            }
        }

        display(res, res.GetLength(0), res.GetLength(1));
    }

    public void multiplyMatrix(int[,] mat1, int[,] mat2)
    {
        int r1 = mat1.GetLength(0);
        int c1 = mat1.GetLength(1);
        int c2 = mat2.GetLength(1);

        int[,] res = new int[r1, c2];

        for (int i = 0; i < r1; i++)
        {
            for (int j = 0; j < c2; j++)
            {
                int sum = 0;
                for (int k = 0; k < c1; k++)
                {
                    sum += mat1[i, k] * mat2[k, j];
                }
                res[i, j] = sum;
            }
        }

        display(res, r1, c2);
    }
    public void display(int[,] mat, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}
