using System;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
namespace _23.OrderWords
{
    class StUpOrderWords
    {
        static void Main()
        {
            string input = "wf wf  sd ae a";
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] < words[j])
                    {

                    }
                }
            }

        }
    }
}
