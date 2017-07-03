using System;

namespace _1Test1.MagicalNumbers
{
    class StUpMagNum
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            float thirdDigit = num % 10;
            int secondDigit = (num / 10) % 10;
            int firstDigit = (num / 100) % 10;

            float result;

            if (secondDigit % 2 == 0)
            {
                result = (firstDigit + secondDigit) * thirdDigit;
            }
            else
            {
                result = firstDigit * secondDigit / thirdDigit;
            }
            Console.WriteLine("{0:0.00}", result);

        }
    }
}
