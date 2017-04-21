using System;

namespace _2.Date
{
    class Date
    {
        static void Main()
        {
            DateTime christmas = new DateTime(2009, 12, 25);

            int day = christmas.Day;
            int month = christmas.Month;
            int year = christmas.Year;

            Console.WriteLine(day);
            Console.WriteLine(month);
        }
    }
}
