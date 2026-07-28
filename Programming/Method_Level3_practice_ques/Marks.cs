//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Methods_Level3_Practice_ques
//{
//    internal class Marks
//    {

//        public void solve()
//        {
//            int n = Convert.ToInt32(Console.ReadLine());
//            int[,] marks = generateRandomMarks(n);
//            display(marks, n);
//            int[,] total_avg_percentage = avgPercentage(marks, n);
//            display(marks, n);

            
//        }

//        public int[,] avgPercentage(int[,] marks, int n)
//        {
//            double[,] res = new double[n, 3];
//            int k = 0;
//            for(int i = 0; i < n; i++)
//            {
//                double total = 0;
//                for(int j = 0; j < 3; j++)
//                { 
//                    total+= marks[i,j];
//                }
//                double avg= total / n;
//                double percentage = Math.Round(100 * total / 300,2);
//                res[i, k] = total;
//                res[i, k + 1] = avg;
//                res[i, k + 2] = percentage;
//            }
//            return res;
//        }
//        public void display(int[,] mat, int n)
//        {
//            for(int i = 0; i < n; i++)
//            {
//                for(int j = 0; j < 3; j++)
//                {
//                    Console.Write($"{mat[i, j]} ");
//                }
//            }
//        }
//        public int[,] generateRandomMarks(int n)
//        {
//            int[,] arr = new int[n, 3];

//            Random rand = new Random();
//            for (int i = 0; i < n; i++)
//            {
//                for (int j = 0; j < 3; j++)
//                {
//                    arr[i, j] = rand.Next(10, 100);
//                }
//            }
//            return arr;
//        }
       

//    }
//}
