using System;

namespace _10.UnicodeCharacters
{
    class StUpUnicodeCharacters
    {
        static void Main()
        {
            //1 way
            string text = Console.ReadLine(); // Hi!

            int temp = 0;

            for (int counter = 0; counter < text.Length; counter++)
            {
                temp = text[counter]; //буквата като число - от ascii ?// 72 105 33

                Console.Write("\\u{0}", temp.ToString("X4"));  // \u0048\u0069\u0021

            }
        }
    }
}
