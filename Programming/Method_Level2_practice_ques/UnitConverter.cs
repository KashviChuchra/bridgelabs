using System;

namespace Method_Level1_Practice_Ques
{
    public static class UnitConvertor
    {
        public static double convertFarhenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        public static double convertCelsiusToFarhenheit(double c)
        {
            return (c * 9 / 5) + 32;
        }

        public static double convertPoundsToKilograms(double lbs)
        {
            return lbs * 0.453592;
        }

        public static double convertKilogramsToPounds(double kg)
        {
            return kg * 2.20462;
        }

        public static double convertGallonsToLiters(double gal)
        {
            return gal * 3.78541;
        }

        public static double convertLitersToGallons(double l)
        {
            return l * 0.264172;
        }
    }

    internal class TestConvertor
    {
        public void solve()
        {
            double val = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(UnitConvertor.convertFarhenheitToCelsius(val));
            Console.WriteLine(UnitConvertor.convertCelsiusToFarhenheit(val));
            Console.WriteLine(UnitConvertor.convertPoundsToKilograms(val));
            Console.WriteLine(UnitConvertor.convertKilogramsToPounds(val));
            Console.WriteLine(UnitConvertor.convertGallonsToLiters(val));
            Console.WriteLine(UnitConvertor.convertLitersToGallons(val));
        }
    }
}
