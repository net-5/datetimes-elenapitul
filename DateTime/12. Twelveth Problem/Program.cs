using System;

namespace _12._Twelveth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //12. Write a program to print yesterday, today, tomorrow.
            //Yesterday: 2017 - 05 - 05
            //Today: 2017 - 05 - 06
            //Tomorrow: 2017 - 05 - 07

            DateTime yesterday = DateTime.Now.AddDays(-1);
            Console.WriteLine("Yesterday: " + yesterday.ToString("yyyy - MM - dd"));
            Console.WriteLine("Today: " + DateTime.Now.ToString("yyyy - MM - dd"));
            DateTime tomorrow = DateTime.Now.AddDays(1);
            Console.WriteLine("Tomorrow: " + tomorrow.ToString("yyyy - MM - dd"));



        }
    }
}
