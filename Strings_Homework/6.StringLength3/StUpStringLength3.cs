using System;

namespace _6.StringLength3
{
    class StUpStringLength3
    {
        static void Main()
        {
            Console.WriteLine("Enter string not better than 20 characters: ");

            string input = Console.ReadLine();

            input = input.PadRight(20, '*');
            Console.WriteLine(input);

            input = input.PadLeft(25, '$');
            Console.WriteLine(input);

        }
    }
}
