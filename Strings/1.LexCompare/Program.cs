using System;

namespace _1.LexCompare
{
    class Program
    {
        static string LexCompare(string left, string right)
        {
            int length = Math.Min(left.Length, right.Length);

            for (int i = 0; i < length; i++)
            {
                if (left[i] < right[i])
                {
                    return "First string is 1 lex!";  // left is first
                }
                else if (left[i] > right[i])
                {
                    return "Second string is 1 lex!";  // right is first
                }
            }

            if (left.Length < right.Length)
            {
                return "First string is 1 lex!";
            }
            else if (left.Length > right.Length)
            {
                return "Second string is 1 lex!";
            }

            return "Equal";
        }

        static void Main()
        {
            while (true)
            {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

                Console.WriteLine(LexCompare(str1,str2));
               // Console.WriteLine(string.Compare(str1,str2,false));
            }
        }
    }
}
