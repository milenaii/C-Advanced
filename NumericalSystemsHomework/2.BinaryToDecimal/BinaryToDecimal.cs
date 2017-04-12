using System;

class BinaryToDecimalll
{
    static int BinaryToDecimal(string number2)
    {
        int result = 0;

        foreach (char digit in number2)
        {
            result = result * 2 + (digit - '0');
            Console.WriteLine(result);
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter a binary number: ");
        string str = Console.ReadLine();
        Console.WriteLine(BinaryToDecimal(str));

    }
}

