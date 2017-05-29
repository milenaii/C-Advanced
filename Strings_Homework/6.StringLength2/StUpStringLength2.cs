using System;
using System.Text;
////Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.

namespace _6.StringLength2
{
    class StUpStringLength2
    {
        static void Main()
        {
            Console.WriteLine("Enter string not better than 20 characters: ");

            string input = Console.ReadLine();
            StringBuilder inp = new StringBuilder();
            inp = inp.Append(input);

            if (inp.Length < 20)
            {
                for (int i = inp.Length; i < 20; i++)
                {
                    inp = inp.Append('*');
                }
                Console.WriteLine(inp);
            }

            else
            {
                Console.WriteLine(inp);
            }

        }
    }
}
