using System;

namespace _14.TrimmingStrings
{
    class StartUpTrim
    {
        static void Main()
        {
            string text = "   kndkvlk kmfe   ";
            Console.WriteLine(text.Trim());
            string text2 = "____lkmsdjh jwef jij***!";
            Console.WriteLine(text2.Trim('_', '!', '*'));
        }
    }
}
