using System;

namespace _2.Compare2
{
    class Program
    {
        static void Main()
        {
            // 1  way
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Console.WriteLine(str1 == str2);

            // 2 way - bool
            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual);
        }
    }
}
