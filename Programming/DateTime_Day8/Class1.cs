using System;
using System.Collections.Generic;
using System.Text;

namespace Day_date_functions
{
    internal class Class1
    {
        public void func()
        {
            string date = Console.ReadLine();
            DateTime output = new DateTime();

            if (DateTime.TryParse(date, out DateTime dt))
            {
                Console.WriteLine($"Data Arithmetic: {DateArithmetic(dt, 1, 1, 1)}");
                Console.WriteLine("Data Formatting: ");
                DateFormatting(dt);

                Console.WriteLine("Data Compare: ");
                string a =Console.ReadLine();
                string b=Console.ReadLine();
                DateTime d1=DateTime.Parse(a);
                DateTime d2=DateTime.Parse(b);

                DateComparision(d1, d2);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.WriteLine(output);


        }

        public void TimeZone_DateTimeOffset()
        {

        }

        public DateTime DateArithmetic(DateTime date, int year, int month, int day)
        {
            date = date.AddDays(day);
            date = date.AddMonths(month);
            date = date.AddYears(year);

            return date;
        }
        public void DateFormatting(DateTime date)
        {
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.ToString("yyyy-MM-dd"));
            Console.WriteLine(date.ToString("MMM dd, yyyy"));
        }

        public void DateComparision(DateTime d1, DateTime d2)
        {
            if (d1.Year > d2.Year)
            {
                Console.WriteLine($"{d2.Date} is before {d1.Date}");
            }
            else if (d1.Year == d2.Year)
            {
                if (d1.Month > d2.Month)
                {
                    Console.WriteLine($"{d2.Date} is before {d1.Date}");
                }
                else if (d1.Month == d2.Month)
                {
                    if (d1.Day > d2.Day)
                    {
                        Console.WriteLine($"{d2.Date} is before {d1.Date}");
                    }
                    else if (d1.Day == d2.Day) {
                        Console.WriteLine($"{d1.Date} and {d2.Date} are equal");
                    }
                    else {
                        Console.WriteLine($"{d1:dd-MM-yyyy} is before {d2:dd-MM-yyyy}");
                    }

                }

            }
            else
            {
                Console.WriteLine($"{d1.Date} is before {d2.Date}");
            }
        }
    }
}
