using System;
using System.Text;
//Write a program that converts a string to a sequence of C# Unicode character literals.
/*Input Hi!
Output \u0048\u0069\u0021*/

namespace _10.UnicodeCharacter
{
    class StUpUnicodeCharacter2
    {
        static void Main()
        {
            Console.WriteLine("Enter some text :");

            string text = Console.ReadLine();

            Console.WriteLine(ParseToUnicode(text));
        }

        private static string ParseToUnicode(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char letter in text)
            {
                result.Append(String.Format("\\u{0:x4}",(int)letter));
            }

            return result.ToString();
        }
    }
}
