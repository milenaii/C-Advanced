using System;
//Write a method that reverses the digits of a given decimal number.
// ex input 12345
namespace _7.ReverseNumber
{

    // this decision is for integers, not decimal
    class ReverseNumberrr
    {
        static string ReverseDigitInNumber(int number)
        {
            string result = "";

            while (number  != 0)
            {
                result += (number % 10).ToString();
                number /= 10;
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseDigitInNumber(input)); 
        }
    }
}