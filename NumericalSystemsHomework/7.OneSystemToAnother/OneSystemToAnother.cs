using System;
//Write a program to convert the number N from any numeral system of given base s 
//to any other numeral system of base d.
class OneSystemToAnother
{
    //1 step 
    static int ConvertOneSystemToDecimal(int oldBase, string number)
    {
        int result = 0;
        foreach (char digit in number)
        {
            result = result * oldBase + (digit - '0');
        }
        return result;
    }
    //2 step
    static string ConvertFromDecimalToOther(int num, int newBase)
    {
        string result = "";
        while (num > 0)
        {
            int a = num % newBase;
            num = num / newBase;
            result = a + result;
        }

        return result;
    }

    static void Main()
    {
        //input
        Console.WriteLine("Enter a base number s:");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter a number N with base s: ");
        string n = Console.ReadLine();

        Console.WriteLine("Enter a base in new system: ");
        int d = int.Parse(Console.ReadLine());

        //Call methods for converting
        Console.WriteLine(ConvertFromDecimalToOther(ConvertOneSystemToDecimal(s,n),d));

    }
}

