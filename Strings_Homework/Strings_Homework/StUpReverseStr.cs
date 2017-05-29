using System;
//Write a program that reads a string, reverses it and prints the result on the console.

    // 1way
namespace Strings_Homework
{
    class StUpReverseStr
    {
        static string ReverseString(string str)
        {
            string reversedStr = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                reversedStr = str[i] + reversedStr;
            }
            return reversedStr;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            
            // Console.WriteLine(DateTime.Now);
            Console.WriteLine(ReverseString(input));

            //Console.WriteLine(DateTime.Now);

            
        }
    }
}
