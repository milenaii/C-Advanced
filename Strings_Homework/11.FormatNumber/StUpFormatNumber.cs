using System;

namespace _11.FormatNumber
{
    class StUpFormatNumber
    {
        static void Main()
        {
            Console.Write("Enter an integer: ");
            int number = int.Parse(Console.ReadLine());

            //1 way
            Console.WriteLine("{0,15:D}", number);
            Console.WriteLine("{0,15:X}", number);
            Console.WriteLine("{0,15:P}", number / 100.0);
            Console.WriteLine("{0,15:E}", number);

            //2 way
            Console.WriteLine("{0,15}", number.ToString("D"));
            Console.WriteLine("{0,15}", number.ToString("X"));
            Console.WriteLine("{0,15}", number.ToString("P"));
            Console.WriteLine("{0,15}", number.ToString("E"));
        }
    }
}
