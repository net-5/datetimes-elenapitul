using System;
using System.Collections.Generic;

namespace _16._Sixteenth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //13. Write a program to select all the Sundays of a specified year and display their dates.
            // Output:
            // 2020 - 01 - 05
            //2020 - 01 - 12
            //2020 - 01 - 19
            // https://www.epochconverter.com/weeks/2020

            Console.WriteLine("Year: ");
            int inputYear = int.Parse(Console.ReadLine());

            DateTime first = new DateTime(inputYear - 1, 12, 31);
            DateTime last = new DateTime(inputYear, 12, 31);

            List<DateTime> sundays = new List<DateTime>();
            while (first < last)
            {
                if(first.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine(first.ToString("yyyy - MM - dd"));
                    sundays.Add(new DateTime(first.Year, first.Month, first.Day));
                    first = first.AddDays(7);                    
                }
                else
                {
                    first = first.AddDays(1);
                }
            }   

        }
    }
}