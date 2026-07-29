using System;
namespace Day_date_functions;

class Program
{
    public static void Main(String[] args)
    {
        Class1 obj=new Class1();
        obj.func();
    }
}



//DateTime now= DateTime.Now;
//DateTime today= DateTime.Today;
//DateTime utc= DateTime.UtcNow;
//Console.WriteLine($"Current Date and time: {now}");
//Console.WriteLine($"Today Date and Time: {today}");
//Console.WriteLine($"UTC: {utc}");
//Console.WriteLine($"UTC: {UtcNow}");


//Console.WriteLine($"{d1:dd-MM-yyyy} is before {d2:dd-MM-yyyy}");


//Console.WriteLine(now.Year);
//Console.WriteLine(now.Month);
//Console.WriteLine(now.Day);
//Console.WriteLine(now.Hour);
//Console.WriteLine(now.Minute);
//Console.WriteLine(now.Second);
//Console.WriteLine(now.Millisecond);

//Console.WriteLine(now.DayOfWeek);        // Monday/Tuesday etc
//Console.WriteLine(now.DayOfYear);        // 1 feb-> returns 32

//Console.WriteLine(now.TimeOfDay);        // returns only time
//Console.WriteLine(now.Date);            //  returns only day


//Console.WriteLine(now.ToShortDateString());
//Console.WriteLine(now.ToLongDateString());

//Console.WriteLine(now.ToShortTimeString());
//Console.WriteLine(now.ToLongTimeString());

//Console.WriteLine(now.ToString());

// difference between printing now vs now.ToString()



//Custom Formatting

//Console.WriteLine(now.ToString("dd-MM-yyyy"));
//Console.WriteLine(now.ToString("dd/MM/yyyy"));
//Console.WriteLine(now.ToString("yyyy-MM-dd"));
//Console.WriteLine(now.ToString("hh:mm:ss"));



// ddd/dddd -> respresnts day eg- jul, july
// MMM/MMMM -> represents month   wed, wednesday

// hh: 12 hr , HH: 24 hr, ss: seconds, tt: AM/PM

//Console.WriteLine(now.ToString("yyyy MMMM dddd"));
//Console.WriteLine(now.ToString("yyyy MMM ddd"));

//Console.WriteLine(now.ToString("HH:mm tt"));



// Add and Subtract Days 

//DateTime date = DateTime.Now;
//Console.WriteLine(date.AddDays(1));
//Console.WriteLine(date.AddMonths(10));
//Console.WriteLine(date.AddYears(1));

//Console.WriteLine(date.AddHours(10));
//Console.WriteLine(date.AddMinutes(10));
//Console.WriteLine(date.AddSeconds(10));

//Console.WriteLine(date.AddMilliseconds(10));


//DateTime d1 = new DateTime(2026, 7, 29);
//DateTime d2 = new DateTime(2026, 2, 20);

// TimeSpan- duration of time
//TimeSpan diff = d1-d2;
//Console.WriteLine(diff.Days);
//Console.WriteLine(diff.Months); ---> give error



// Compare Dates
// using relational operators, .compare, .equals 





// Convert String into Date

//1. Parse()
//        a. DateTime date = DateTime.Parse(str);
//        b. if str is in correct format -> datatype will be changed
//        c. else -> FormatException
//        d. Unsafe Method

//2. TryParse()
//        a. bool res= DateTime.TryParse(out DateTime date)
//        b. if str is in correct format , res=true -> datatype will be changed , and we can print
//        c. else , res=false -> even if we here print date it gives default value which is 01/01/0001




// isLeapYear
//Console.WriteLine(DateTime.IsLeapYear(2024));

// DAYS IN month
// Console.WriteLine(DateTime.DaysInMonth(2026,2));

//UTC = Coordinated Universal Time

//It is the world's standard time from which all time zones are calculated.
//If UTC time is

//10:00 AM

//then
//India = 3:30 PM


//TimeSpan t = new TimeSpan(26, 30, 0);

//What does it represent?

//26 hours
//30 minutes

//Internally

//1 day
//2 hours
//30 minutes




//Different countries display data differently
//India -   29/07/2026;     1,23,456.78
//USA -     07/29/2026;     123,456.78
//Japan -   2026/07/29;     123.456,78

// CultureInfo: tell .net how to format and interpret dates, numbers, currency, etc., for a particular culture or region.
// CultureInfo.InvariantCulture:    Culture-independent formatting and parsing, ideal for files, APIs, databases, and data exchange















