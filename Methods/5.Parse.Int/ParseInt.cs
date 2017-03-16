using System;

namespace _5.Parse.Int
{
    class ParseInttt
    {
        static int ParseInt(string numberAsString)
        {
            int result = 0;

            //for (int i = 0; i < numberAsString.Length; i++)
            //{
            //    int digitValue = numberAsString[i] - '0';
            //    //ascii code 0 = 48  -> '0', 1 -> 49 .....

            //    result += (int)(digitValue * Math.Pow(10, numberAsString.Length - 1 - i)); 
            //}

            foreach (var digit in numberAsString)
            {
                result = result * 10 + (digit - '0');
              //  Console.WriteLine(result);    za da se razbere
            }


            return result;
        }

        static void Main()
        {
            int number = ParseInt("12361");
            Console.WriteLine(number +5);

        }
    }
}
