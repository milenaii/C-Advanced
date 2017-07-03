using System;

namespace _4.TryFinally
{
    class StUpTryFinally
    {
        static void ReadUserNumber()
        {
            try
            {
                int.Parse(Console.ReadLine());  
            }
            catch (FormatException)  // когато не използваме име на ексепш, не го кръщаваме
            {
                Console.WriteLine("Bad Format!");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value is too big!");
                //return;        - ако прекъснем тук, то finally пак ще се изпълни, ако няма finally - онзи код няма да се изпълни
            }
            finally
            {
                Console.WriteLine("Doing some cleanup!");
            }
        }

        static void Main()
        {
            ReadUserNumber();
        }
    }
}
