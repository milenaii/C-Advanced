using System;

namespace ExceptionHandling
{
    class Program
    {
        static int Parse(string number)
        {
            var result = 0;

            foreach (char symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    throw new FormatException();
                }

                result = result * 10 + (symbol - '0');
            }

            return result;
        }

        static void Main()
        {
            int userAge;

            try
            {
                userAge = int.Parse(Console.ReadLine());
                Console.WriteLine($"You are {userAge} years old");
            }
            catch 
            {
                Console.WriteLine("You probably entered an invalid value!");
                //тук може да има и други операции, не само cw
                //ако има try, ще има и catch, иначе - не!
            }
            Console.WriteLine("End of program");
        }
    }
}
