using System;

namespace _10.ReplaceAndRemove
{
    class StartUpReplaceAndRemove
    {
        static void Main()
        {
            string text = "vbscript This is some texty  actionscript text stuff gosho penka ivan csharp javascript html gosho css";

            //може символи
            //text.Replace('a', 'b');

            // or strings  
            string replacedText =  text.Replace("gosho", "serious business");

            Console.WriteLine(replacedText);

            text = text.Replace('i', 'a');
            Console.WriteLine(text);

        }
    }
}
