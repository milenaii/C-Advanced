using System;
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
namespace _20.Palindromes
{
    class StUpPalindromes
    {
        static void Main()
        {
            Console.WriteLine("Enter some text where the program is going to serch palindromes: ");
            string input = Console.ReadLine();
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';' });
            foreach (string word in words)
            {
                if (CheckWordPalindrome(word) == true)
                {
                    Console.WriteLine(word);
                }
            }
        }

        private static bool CheckWordPalindrome(string word)
        {
            bool palind = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[word.Length - 1 - i])
                {
                    palind = true;
                }
                else
                {
                    palind = false;
                    break;
                }
            }
            return palind;
        }
    }
}
