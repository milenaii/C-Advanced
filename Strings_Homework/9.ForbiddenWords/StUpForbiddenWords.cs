using System;
//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks.
//sample test
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.


namespace _9.ForbiddenWords
{
    class StUpForbiddenWords
    {
        static void Main()
        {
            //Console.WriteLine("Enter forbidden words, divided with comma: ");

            string forbiddenWords = "C#,CLR,Microsoft,PHP";
            //string forbiddenWords = Console.ReadLine();

            string[] forbWords = forbiddenWords.Split(',', ' ');

            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            string rep = "";
            
            for (int i = 0; i < forbWords.Length; i++) // for all forbidden words
            {
                for (int j = 0; j < text.Length; j++)  // to the end of the text
                {
                    int w = text.IndexOf(forbWords[i]);
                    if (w != -1)
                    {
                        for (int m = 0; m < forbWords[i].Length; m++)// how many symbols
                        {                                            // to be replaced
                            rep += "*";
                        }
                        text = text.Replace(forbWords[i], rep);
                    }
                    rep = "";
                }
            }
            Console.WriteLine(text);
        }
    }
}
