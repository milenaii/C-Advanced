using System;
using System.Text;
//Write a program that reads a string, reverses it and prints the result on the console.

//2 way

namespace _2.ReverseString
{
    class StartUpReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder reversedStr = new StringBuilder();

            for (int i = input.Length; i  > 0 ; i--)
            {
                reversedStr.Append(i);
            }
            Console.WriteLine(reversedStr);
        }
    }
}
