using System;


namespace UsingClassesAndObjects_Homework
{
    class LeapYear
    {
        static void Main()
        {
            Console.WriteLine("Enter a Year:");

            int input = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(input))
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }

        }
    }
}
