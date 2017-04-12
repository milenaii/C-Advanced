using System;
//Write a program that converts a hexadecimal number N to its decimal representation
class HexadecimalToDecimalll
{
    static int ConvertHexadecimalToDecimalNUmber(string num16)
    {
        int res = 0;

        foreach (char num in num16)
        {
            if (char.IsDigit(num))
            {
                res = res * 16 + (num - '0');
            }
            else
            {
            res = res * 16 + (num - 'A' + 10); // num- 'A'ни води до 0, а ние искаме
            }                                   // A = 10, B = 11..., -> +10
        }
        return res;
    }

    static void Main()
    {
        Console.WriteLine("Enter a hexadecimal number: ");
        string n = Console.ReadLine();
        Console.WriteLine(ConvertHexadecimalToDecimalNUmber(n));

    }
}

