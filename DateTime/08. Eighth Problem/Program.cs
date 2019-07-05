using System;
using Third_Problem;

namespace _08._Eighth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Write a program to calculate two date difference in seconds.
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
            var diff_sec = (date1 - date2).TotalSeconds;
            Console.WriteLine(diff_sec);

            //Just checking
            DateTime a = DateTime.Now;
            DateTime b = a.AddSeconds(100); 
            var dif = (b - a).TotalSeconds;
            Console.WriteLine(dif);

        }
    }
}
