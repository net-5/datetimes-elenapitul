using System;
using System.Globalization;

namespace _14._Fourteenth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Second 11. Write a program to find the date of the first Monday of a given week
            //Input: 2015, 50
            //Output: Mon Dec 14 00:00:00 2015
            //https://www.epochconverter.com/weeks/2015

            Console.WriteLine("Year: ");
            int inputYear = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Week: ");
            int inputWeek = int.Parse(Console.ReadLine());
            while (( inputWeek < 1) || (inputWeek > 53))
            {
                Console.WriteLine("Try again");
                inputWeek = int.Parse(Console.ReadLine());
            }

            DateTime date = new DateTime(inputYear, 1, 1).AddDays((inputWeek - 1) * 7);
            Console.WriteLine(date.ToString("F"));
            Console.WriteLine();
            DateTime monday = date.AddDays(-(int)date.DayOfWeek + 1);
            Console.WriteLine(monday.ToString("F"));
            
        }
    }
}
