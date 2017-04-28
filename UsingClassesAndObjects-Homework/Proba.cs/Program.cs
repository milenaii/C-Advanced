﻿using System;
using System.Collections.Generic;

class Workdays
{
    static List<DateTime> publicHolydays;
    static void Main()
    {
        int currentYear = DateTime.Now.Year;

        // list of public holidays
        publicHolydays = new List<DateTime>() { new DateTime(currentYear, 1, 1),
            new DateTime(currentYear, 3, 2), new DateTime(currentYear, 3, 3),
            new DateTime(currentYear, 4, 10), new DateTime(currentYear, 4, 11),
            new DateTime(currentYear, 4, 12), new DateTime(currentYear, 4, 13),
            new DateTime(currentYear, 5, 1), new DateTime(currentYear, 5, 6),
            new DateTime(currentYear, 9, 21), new DateTime(currentYear, 9, 22),
            new DateTime(currentYear, 12, 24), new DateTime(currentYear, 12, 25),
            new DateTime(currentYear, 12, 26), new DateTime(currentYear, 12, 31),};

        // gets the current date
        DateTime currentDate = DateTime.Today;

        Console.Write("Enter a date in format (dd.mm.yyyy): ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        // Output
        Console.WriteLine(CountWorkdays(currentDate, date));
    }
    private static string CountWorkdays(DateTime startDate, DateTime endDate)
    {
        int workDays = 0;
        int holydays = 0;
        int weekends = 0;

        while (startDate <= endDate)
        {
            if (publicHolydays.Contains(startDate))
            {
                holydays++;
            }
            else if ((int)startDate.DayOfWeek == 6 || (int)startDate.DayOfWeek == 0)    
            {
                weekends++;
            }
            else
            {
                workDays++;
            }
            startDate = startDate.AddDays(1);
        }
        return String.Format(@"
        Holydays: {0}
        Weekends: {1}
        Workdays: {2}
        ", holydays, weekends, workDays);
    }
}