using System;
//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
namespace _6.StringLength
{
    class StUpStringLength
    {
        static void Main()
        {
            Console.WriteLine("Enter string not better than 20 characters: ");
            string input = Console.ReadLine();

            if (input.Length < 20)
            {
                for (int i = input.Length; i < 20; i++)
                {
                    input = input + "*";
                }
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine(input);
            }

        }
    }
}
