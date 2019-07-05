using System;
using Third_Problem;

namespace _15._Fifthteenth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Second 12. Write a program to get days between two dates.
            //Input:
            //2000,2,2
            //2001,2,28
            //Output: 366 days, 0:00:00
            //It's a different output.

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
            DateTime a = new DateTime(2000, 2, 2);
            DateTime b = new DateTime(2001, 2, 28);
            var dif = (b - a).TotalDays;
            Console.WriteLine(dif);

            
        }
    }
}
