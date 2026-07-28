using System;

namespace Method_Level1_Practice_Ques
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select Option:\n1. ArrayMethodChecker\n2. BmiTracker\n3. DistanceConverter\n4. FactorCalculator\n5. FriendsHeight\n6. LeapYear\n7. MathFunction\n8. RandomNumber\n9. UnitConverter\n10. VoteChecker");
            int opt = Convert.ToInt32(Console.ReadLine());

            if (opt == 1)
            {
                ArrayMethodChecker obj = new ArrayMethodChecker();
                obj.solve();
            }
            else if (opt == 2)
            {
                BmiTracker obj = new BmiTracker();
                obj.solve();
            }
            else if (opt == 3)
            {
                TestDistanceConvertor obj = new TestDistanceConvertor();
                obj.solve();
            }
            else if (opt == 4)
            {
                FactorCalculator obj = new FactorCalculator();
                obj.solve();
            }
            else if (opt == 5)
            {
                FriendsHeight obj = new FriendsHeight();
                obj.solve();
            }
            else if (opt == 6)
            {
                LeapYear obj = new LeapYear();
                obj.solve();
            }
            else if (opt == 7)
            {
                TestConvertor obj = new TestConvertor();
                obj.solve();
            }
            else if (opt == 8)
            {
                VoteChecker obj = new VoteChecker();
                obj.solve();
            }
        }
    }
}
