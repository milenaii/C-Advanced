using System;

namespace ProbaM
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter letters to count: ");

            string text = Console.ReadLine();

            char[] letters = new char[255];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    letters[text[i]]++;
                }
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter((char)i) && letters[i] > 0)
                {
                    Console.WriteLine("{0} - {1} times", (char)i, (int)letters[i]);
                }
            }
        }
    }
}
