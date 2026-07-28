using System;

namespace Method_Level1_Practice_Ques
{
    public static class DistanceConvertor
    {
        public static double ConvertKmToMiles(double km)
        {
            return km * 0.621371;
        }

        public static double ConvertMilesToKm(double miles)
        {
            return miles * 1.60934;
        }
    }

    internal class TestDistanceConvertor
    {
        public void solve()
        {
            double val = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(DistanceConvertor.ConvertKmToMiles(val));
            Console.WriteLine(DistanceConvertor.ConvertMilesToKm(val));
        }
    }
}
