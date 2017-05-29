using System;

namespace _5.ParseTags
{
    class StUpParseTag
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string textInput = Console.ReadLine();

            Console.WriteLine(TagsToUpper(textInput));
        }

        private static string TagsToUpper(string text)
        {
            while (text.IndexOf("<upcase>") != -1)
            {
                int indexStart = text.IndexOf("<upcase>");
                int indexEnd = text.IndexOf("</upcase>");

                string sub = text.Substring(indexStart, indexEnd - indexStart);

                string result = text.Replace(sub, sub.ToUpper());
                result = result.Remove(indexEnd, 9);
                text = result.Remove(indexStart, 8);
            }
            return text;
        }
    }
}


