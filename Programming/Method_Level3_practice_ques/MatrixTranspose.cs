using System;
using System.Collections.Generic;
using System.Text;

namespace Methods_Level3_Practice_ques;

public class MatrixTranspose
{
    public void solve()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mat = new int[n, n];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                mat[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int[,] new_mat= (int[,])mat.Clone();
        transpose(new_mat,n);

        if (n == 2)
        {
            Console.WriteLine(determinant2D(mat, n));
            inverse2D(mat, n);
        }
        else if (n == 3)
        {
            Console.WriteLine(determinant3D(mat, n));
            inverse3D(mat, n);

        }


    }

    public void transpose(int[,] mat, int n)
    {
        for(int i = 0; i < n; i++)
        {
            for(int j = i+1; j < n; j++)
            {
                int temp = mat[i, j];
                mat[i, j] = mat[j, i];
                mat[j, i] = temp;
            }
        }

        display(mat, n);
    }

    public int determinant2D(int[,] mat, int n)
    {
        return mat[0, 0] * mat[1, 1] - mat[0, 1] * mat[1, 0];
    }

    public int determinant3D(int[,] mat, int n)
    {
        int a = mat[0, 0];
        int b = mat[0, 1];
        int c = mat[0, 2];
        int d = mat[1, 0];
        int e=  mat[1, 1];
        int f = mat[1, 2];
        int g = mat[2, 0];
        int h = mat[2, 1];
        int i = mat[2, 2];

        return a * (e * i - f * h) - b * (d * i - g * f) + c * (d * h - e * g);

    }
    public void inverse2D(int[,] mat, int n)
    {
        int determinant = determinant2D(mat, n);
        if (determinant == 0)
        {
            Console.WriteLine("Matrix is singular. Inverse do not exist");
            return;
        }
        int[,] adjoint = adjoint_matrix2D(mat, n);
        double[,] inverse = new double[n, n];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                inverse[i,j] = (double)adjoint[i, j] / determinant;
            }
        }
        displayDouble(inverse, n);
    }
    
    public void inverse3D(int[,] mat, int n)
    {
        int determinant = determinant3D(mat, n);
        if (determinant == 0)
        {
            Console.WriteLine("Matrix is singular. Inverse do not exist");
            return;
        }
        int[,] adjoint = adjoint_matrix3D(mat, n);
        double[,] inverse = new double[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                inverse[i, j] = (double)adjoint[i, j] / determinant;
            }
        }
        displayDouble(inverse, n);
    }



    public int[,] adjoint_matrix2D(int[,] mat, int n)
    {
        int[,] res= new int[n,n];

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if( (i==0 && j==1) || (i==1 && j == 1))
                {
                    res[i, j] = -1*mat[i, j];
                }
                else
                {
                    res[i, j] = mat[i, j];
                }
            }
        }
        return res;
    }

    public static int[,] adjoint_matrix3D(int[,] mat, int n)
    {
        int[,] adj = new int[n, n];
        adj[0, 0] = (mat[1, 1] * mat[2, 2] - mat[1, 2] * mat[2, 1]);
        adj[1, 0] = -(mat[1, 0] * mat[2, 2] - mat[1, 2] * mat[2, 0]);
        adj[2, 0] = (mat[1, 0] * mat[2, 1] - mat[1, 1] * mat[2, 0]);

        adj[0, 1] = -(mat[0, 1] * mat[2, 2] - mat[0, 2] * mat[2, 1]);
        adj[1, 1] = (mat[0, 0] * mat[2, 2] - mat[0, 2] * mat[2, 0]);
        adj[2, 1] = -(mat[0, 0] * mat[2, 1] - mat[0, 1] * mat[2, 0]);

        adj[0, 2] = (mat[0, 1] * mat[1, 2] - mat[0, 2] * mat[1, 1]);
        adj[1, 2] = -(mat[0, 0] * mat[1, 2] - mat[0, 2] * mat[1, 0]);
        adj[2, 2] = (mat[0, 0] * mat[1, 1] - mat[0, 1] * mat[1, 0]);

        return adj;

    }
    public void displayDouble(double[,] mat, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

    }
    public void display(int[,] mat, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{mat[i, j]} ") ;
            }
            Console.WriteLine();
        }

    }
}
