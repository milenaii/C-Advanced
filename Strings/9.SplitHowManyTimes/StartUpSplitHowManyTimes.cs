using System;

namespace _9.SplitHowManyTimes
{
    class StartUpSplitHowManyTimes
    {
        static void Main()
        {
            string sentense = @"How many times text is in text, here is some text, here is another text";
            string [] separate = sentense.Split(new string[] {"text"}, StringSplitOptions.None);
            //без махане на празните, з/о бр "text" няма да е верен

            Console.WriteLine(separate.Length - 1); // number of "text"
            foreach (string part in separate)
            {
                Console.WriteLine(part);
            }
        }
    }
}
