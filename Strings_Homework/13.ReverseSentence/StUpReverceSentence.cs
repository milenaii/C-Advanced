using System;
//Write a program that reverses the words in a given sentence.
namespace _13.ReverseSentence
{
    class StUpReverceSentence
    {
        static void Main()
        {
            // 1 way - we do not save the sign
            string input = "ABC DE FG. ";

            string result = "";

            foreach (char letter in input)
            {
                result = letter + result;
            }
            Console.WriteLine(result);

       }
    }
}
