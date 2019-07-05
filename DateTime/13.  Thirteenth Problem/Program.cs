using System;

namespace _13.__Thirteenth_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //Second 10. Write program to print next 5 days starting from today.
            DateTime today = DateTime.Now;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(today.AddDays(i));
            }
        }
    }
}
