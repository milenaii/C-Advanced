using System;

namespace _21.LettersCount
{
    class StUpLettersCount
    {
        static void Main()
        {
            Console.Write("Enter letters to count: ");

            string text = Console.ReadLine();

            char[] letters = new char[255]; // масив от char - 0 елем - 0'\0'
                                                          //   1 елем - 0'\0'  и т.н 
                                                         //ако добавим елем, к сме
                                                         // срещнали, ще стане
            for (int i = 0; i < text.Length; i++)         // 1'\u0001', ако срещнем 
            {                                             // a (97) - 5 пъти
                if (char.IsLetter(text[i]))               // 5'\u0005' 
                {
                    letters[text[i]]++;
                }
            }
            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLetter((char)i) && letters[i] > 0)
                {
                    Console.WriteLine("'{0}'- {1} times", (char)i, (int)letters[i]);
                }
            }
        }
    }
}
