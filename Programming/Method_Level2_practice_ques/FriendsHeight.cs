using System;

namespace Method_Level1_Practice_Ques
{
    internal class FriendsHeight
    {
        public void solve()
        {
            int[] age = new int[3];
            double[] h = new double[3];
            string[] names = { "Amar", "Akbar", "Anthony" };

            for (int i = 0; i < 3; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());
                h[i] = Convert.ToDouble(Console.ReadLine());
            }

            int youngIdx = FindYoungest(age);
            int tallIdx = FindTallest(h);

            Console.WriteLine(names[youngIdx]);
            Console.WriteLine(names[tallIdx]);
        }

        public int FindYoungest(int[] age)
        {
            int idx = 0;
            for (int i = 1; i < age.Length; i++)
            {
                if (age[i] < age[idx])
                {
                    idx = i;
                }
            }
            return idx;
        }

        public int FindTallest(double[] h)
        {
            int idx = 0;
            for (int i = 1; i < h.Length; i++)
            {
                if (h[i] > h[idx])
                {
                    idx = i;
                }
            }
            return idx;
        }
    }
}
