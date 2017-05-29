using System;
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
namespace _24.OrderWords
{
    class Program
    {
        static void Main()
        {
            string input = "az kmkd  kkk bb fff cc";
            string[] words = input.Split(new char[] { ' ', ',', '.', '!', '?', '-', '(', ')', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            // метод на мехурчето
            for (int j = 0; j < words.Length; j++)
            {
                for (int i = 0; i < words.Length - 1; i++) 
                {
                    if (words[i].CompareTo(words[i + 1]) == 1) //swap the words
                    {
                        string tmp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = tmp;
                    }
                }
            }
            //print the words
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i] + " ");
            }
        }
    }
}
