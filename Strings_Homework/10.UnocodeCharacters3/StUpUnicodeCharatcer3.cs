using System;

namespace _10.UnocodeCharacters3
{
    class StUpUnicodeCharatcer3
    {
        static void Main()
        {
            Console.WriteLine("Enter some text: ");
            string text = Console.ReadLine();

            foreach (char let in text)
            {
                Console.Write(String.Format("\\u{0:x4}", (ushort)let));
            }
            Console.WriteLine();
        }
    }
}
