using System;

namespace _4.SubstringInText
{
    class StUpSubstringInText
    {
        static void Main()
        {
            string sub = Console.ReadLine();
            string text = Console.ReadLine();

            sub = sub.ToLower();
            text = text.ToLower();

            Console.WriteLine(CountSubtring(text, sub));
        }

        private static int CountSubtring(string text, string sub)
        {
            int count = 0;
            int currentIndex = text.IndexOf(sub,0);

            while (currentIndex != -1)
            {
                count++;
                currentIndex = text.IndexOf(sub, currentIndex + 1);
            }
            return count;

            // 2way - for loop

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (currentIndex != -1) // има съвпадение
            //    {
            //        count++;
            //        currentIndex = text.IndexOf(sub, currentIndex + 1);
            //    }
            //}
           // return count;   
        }
    }
}
