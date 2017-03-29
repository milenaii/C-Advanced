using System;
// 16 - разрешени цифри 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A(10), B(11), C(12), D(13), 
//E(14), F(15)
namespace ConvertFromHexToDec
{
    class ConvertFromHexToDeccc
    {
        static int ConvertFromHexToDec(string numHex)
        {
            int result = 0;

            foreach (char digit in numHex)
            {
                int digitValue;

                 if (char.IsDigit(digit))
               // if ((0 <= digit) ^ (digit <= 9)) не работи, тр else if (...)
                {
                    digitValue = digit - '0';
                }
                else
                {
                    digitValue = (digit - 'A') + 10;
                }

                result = result * 16 + digitValue;
            };

            return result;
        }

        static void Main()
        {
            string[] test16 = {
                "AA",   //170
                "10",   //16
                "21",   //33
                "1A",   //26
                "FE",   //254
                "ABC"   //2748
            };

            foreach (string t in test16)
            {
                Console.WriteLine(ConvertFromHexToDec(t));
            }

        }
    }
}
