using System;
using System.Text;
//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
namespace _23.SeriesOfLetters
{
    class StUpSeriesOfLetters
    {
        static void Main()
        {
            string input = "mccckkkkkkkkmkmkmmmmmm";

            StringBuilder output = new StringBuilder();
            output.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] != input[i])
                {
                    output.Append(input[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
