using System;
//Write a program that reads a number and calculates and prints its square root.
//If the number is invalid or negative, print Invalid number.
//In all cases finally print Good bye. Use try-catch-finally block.
namespace ExceptionsHomework
{
    class StUp
    {
        static void Main()
        {
            Console.WriteLine("Engter a number: ");

            try
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    throw new FormatException("Number must be not negative");
                }  
                Console.WriteLine(Math.Sqrt(num));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }

                
        }
    }
}
