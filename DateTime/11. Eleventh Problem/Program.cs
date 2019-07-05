using System;
using Third_Problem;

namespace _11._Eleventh_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //11. Write a program to calculate a number of days between two dates.
            RandomDateTime randDate1 = new RandomDateTime();
            DateTime date1 = randDate1.Next();

            RandomDateTime randDate2 = new RandomDateTime();
            DateTime date2 = randDate2.Next();

            if (date1 < date2)
            {
                var temp = date2;
                date2 = date1;
                date1 = temp;
            }

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            var diff_days = (date1 - date2).TotalDays;
            Console.WriteLine(diff_days);

            //Just checking
            DateTime a = DateTime.Now;
            DateTime b = a.AddDays(50);
            var dif = (b - a).TotalDays;
            Console.WriteLine(dif);
        }
    }
}
