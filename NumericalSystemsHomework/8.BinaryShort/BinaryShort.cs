using System;
//Write a program that shows the binary representation of given 16-bit 
//signed integer number N (the C# type short).
class BinaryShort
{
    static string ConvertDecToBin(int number)
    {
         string result = ""; //цифрите в разл бр с-ми можем да ги запазв само в string
       
        while (number > 0)
        {
            int a;
            a = number % 2;
            number = (short) (number / 2);
            // result = result + a;    цифрите са обърнати, затова:
            result = a + result;
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            // - числа са с единица най-отляво

            Console.WriteLine("1" + ConvertDecToBin(- n).PadLeft(15, '0'));
        }
        else
        {
        Console.WriteLine(ConvertDecToBin(n).PadLeft(16, '0'));
        }
    }

}

