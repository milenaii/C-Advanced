using System;

namespace Substring
{
    class StartUpSubstr
    {
        static void Main()
        {
            string text = "Here is some boaring text";

            string substr = text.Substring(4);  // от 4 нататък

            Console.WriteLine(substr);

            string substr2 = text.Substring(4, 5); // от 4 , 5 символа

            Console.WriteLine(substr2);


            // !!!!! На изпита се пада!
            //take symbol from A to B
            int from = 3;
            int to = 10;
            text = "0123456789ABCDEF";
            string result = text.Substring(from, to - from); //Без B
            Console.WriteLine(result);
            string result2 = text.Substring(from, to - from + 1);// включ B

        }
    }
}
