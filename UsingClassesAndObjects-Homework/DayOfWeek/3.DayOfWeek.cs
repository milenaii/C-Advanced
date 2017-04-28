using System;
//Write a program that prints to the console which day of the week is today.
namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            //1 way
            Console.WriteLine(DateTime.Now.DayOfWeek);

            //2 way
            Console.WriteLine(DateTime.Today.DayOfWeek);

            //Others

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Today);
        }
    }
}
