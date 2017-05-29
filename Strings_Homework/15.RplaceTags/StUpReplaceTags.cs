using System;
//Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).

// it is not finished....

namespace _15.ReplaceTags
{
    class StUpReplaceTags
    {
        static void Main()

        {
            string input = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";


            string tagStart = "<a href=\"";
            string tagEnd = "\">";

            string tagStartReplace = "(";
            string tagEndReplace = ")[";
            string tag = "</a>";
            string tagReplace = "]";

            string text = "";

            text = input.Replace(tagStart, tagStartReplace);
            text = text.Replace(tagEnd,tagEndReplace);
            text = text.Replace(tag, tagReplace);

            Console.WriteLine(text);
            Console.WriteLine();

        }
    }
}
