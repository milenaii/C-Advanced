using System;
//we want method  that convert number from console in some numerical system to decimal

namespace _2.ConvertToDecimal
{
    class ConvertToDecimalll
    {
        static int ConvertToDecimal(string number, int baseOfNum)
        //this method works for 2 ....10 num sys
        {
            int result = 0;

            foreach (var digit in number)
            {
                result = result * baseOfNum + (digit - '0');
            }

            return result;
        }

        static void Main()
        {
            string[] testDvoichna = {
                //цифри 0,1
                "1101",   //13
                "11",     //3
                "10",     //2
                "1",      //1 
                "100",    //4
                "1111"    //15
            };

            foreach (string t in testDvoichna)
            {
                Console.WriteLine(ConvertToDecimal(t, 2));
            }

            string [] testTretichna =
                //цифри 0,1,2
                {
                "10",   //3
                "11",   //4
                "12",   //5
                "20",   //6
                "221"   
            };

            foreach (string t3 in testTretichna)
            {
                Console.WriteLine(ConvertToDecimal(t3,3));
            }


        }
    }
}
