using System;

namespace ConsoleApplication2
{
    class StUpSpellCaster
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] words = input.Split(' ');

            string fir = "";

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    fir += words[i][words.Length - i - 1];
                }
            }

            Console.WriteLine(fir);
        }
    }
}
