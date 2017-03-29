using System;

namespace NumericalSystems
{
    class ParseInttt
    {
        static int ParseInt(string number)
        {
            int result = 0;

            foreach (var digitInString in number)
            {
                result = result * 10 + (digitInString - '0');

                // четем цифрите една по една като започваме от първата
                //като умножаваме с 10, текущите цифри ги избутваме наляво и новата
                // цифра идва от дясно
                Console.WriteLine(result);  //this is to understand what is happened
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number: ");
            Console.WriteLine(ParseInt(Console.ReadLine()));
        }
    }
}
