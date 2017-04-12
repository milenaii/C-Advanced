using System;
//Write a program that converts a decimal number N to its binary representation

namespace NumericalSystemsHomework
{
    class DecimalToBinaryyy
    {
        static string ConvertDecToBin(int number)
        {
            string result = ""; //цифрите в разл бр с-ми можем да ги запазв само в string
            
            while (number > 0)
            {
                int a;
                a = number % 2;
                number = number/2;
                // result = result + a;    цифрите са обърнати, затова:
                result = a + result;
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter a decimal number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertDecToBin(n));
        }

    }
}
