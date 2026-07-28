using System;

namespace Method_Level1_Practice_Ques
{
    public class VoteChecker
    {
        public void solve()
        {
            int[] age = new int[10];

            for (int i = 0; i < age.Length; i++)
            {
                age[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < age.Length; i++)
            {
                if (CanStudentVote(age[i]))
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }

        public bool CanStudentVote(int age)
        {
            if (age < 0)
            {
                return false;
            }
            return age >= 18;
        }
    }
}
