using System;

namespace ExamsForTheTestAlpha
{
    class ProgramStUp
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());

            int thirdDigit = num % 10;
            int secondDigit = (num / 10) % 10;
            float firstDigit = (num / 100) % 10;

            float result;

            if (thirdDigit == 0)
            {
                result = firstDigit * secondDigit;
               Console.WriteLine("{0:F2}", result);

            }
            else if ((thirdDigit > 0) && (thirdDigit <= 5))
            {
                result = (firstDigit * secondDigit) / thirdDigit;
               Console.WriteLine("{0:F2}", result);
            }
            else if (thirdDigit > 5)
            {
               result = (firstDigit + secondDigit) * thirdDigit;
               Console.WriteLine("{0:F2}", result);
            }
        }
    }
}
