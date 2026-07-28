using System;

namespace Method_Level1_Practice_Ques
{
    internal class LeapYear
    {
        public void solve()
        {
            int year = Convert.ToInt32(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leap Year");
            }
        }

        public bool IsLeapYear(int y)
        {
            if (y < 1582)
            {
                return false;
            }
            return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
        }
    }
}
