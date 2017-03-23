using System;
using System.Numerics;

namespace _10.NFactorial
{
    class NFactorialll
    {
        static BigInteger CalculateFactorial(int num)
        {
            BigInteger factorial = 1;

            for (int i = num; i > 0; i--)
            {
                factorial *= i;
            }

            return factorial;
        }


        static void Main()
        {
            Console.WriteLine("Enter an integer number < 1024 ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(num));
        }
    }
}
