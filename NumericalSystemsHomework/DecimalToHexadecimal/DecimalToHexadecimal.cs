using System;

class DecimalToHexadecimalll
{
    static string DecimalToHexadecimal(int number10)
    {
        string result = "";

        while (number10 > 0)
        {
            int cur;
            cur = number10 % 16;
            number10 /= 16;


            switch (cur)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    result = cur + result;
                    break;
                case 10:
                    result = 'A' + result;
                    break;
                case 11:
                    result = 'B' + result;
                    break;
                case 12:
                    result = 'C' + result;
                    break;
                case 13:
                    result = 'D' + result;
                    break;
                case 14:
                    result = 'E' + result;
                    break;
                case 15:
                    result = 'F' + result;
                    break;
                default:
                    break;
            }
        }
        return result;
    }

    static void Main()
    {
        Console.WriteLine("Enter a decimal number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToHexadecimal(n));

    }
}

