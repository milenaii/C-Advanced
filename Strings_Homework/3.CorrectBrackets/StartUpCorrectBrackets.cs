using System;
//Write a program to check if in a given expression the ( and ) 
//brackets are put correctly.
namespace _3.CorrectBrackets
{
    class StartUpCorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int d = 0;
            int l = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    d++;
                }
                else if (input[i] ==')')
                {
                    l++;
                }
            }
            Console.WriteLine( d == l ? "Correct" : "Incorrect");
        }
    }
}
