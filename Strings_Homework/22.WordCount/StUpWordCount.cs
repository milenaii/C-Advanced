using System;
//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
namespace _22.WordCount
{
    class StUpWordCount
    {
        static void Main()
        {
            string input = "mi mi,mi.mi lis lis sdfn sfk";
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '-', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            int[] wordsCount = new int[words.Length];

            for (int i = 0; i < wordsCount.Length; i++)
            {
                wordsCount[i] = 1;

                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        words[j] = null;
                        wordsCount[i]++;
                        wordsCount[j]++;
                    }
                }
            }
            for (int i = 0; i < wordsCount.Length; i++)
            {
                if (words[i] != null)
                {
                    Console.WriteLine("{0} -> {1}", words[i], wordsCount[i]);
                }
            }
        }

    }
}

