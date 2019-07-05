using System;
using System.Globalization;

namespace First_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to display the:
            Console.WriteLine("a) Current date and time");
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("b) Current year");
            Console.WriteLine(DateTime.Now.Year);

            Console.WriteLine("c) Month of year");
            Console.WriteLine(DateTime.Now.Month);

            Console.WriteLine("d) Week number of the year");
            Console.WriteLine(CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(DateTime.Now,CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday));

            Console.WriteLine("e) Weekday of the week");
            Console.WriteLine(CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(DateTime.Now));

            Console.WriteLine("f) Day of year");
            Console.WriteLine(CultureInfo.InvariantCulture.Calendar.GetDayOfYear(DateTime.Now));

            Console.WriteLine("g) Day of the month");
            Console.WriteLine(CultureInfo.InvariantCulture.Calendar.GetDayOfMonth(DateTime.Now));

            Console.WriteLine("h) Day of week");
            Console.WriteLine(CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(DateTime.Now));

            Console.WriteLine("j) Is current year a leap year or no?");
            Console.WriteLine(DateTime.IsLeapYear(DateTime.Now.Year));


        }
    }
}
