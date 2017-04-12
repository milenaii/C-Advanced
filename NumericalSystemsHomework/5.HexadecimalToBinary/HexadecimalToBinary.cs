using System;
//Write a program to convert hexadecimal numbers to binary numbers (directly).
class HexadecimalToBinaryyy
{
    static string ConvertHexadecimalToBinary(string num16)
    {
        string result = "";
        //string[] digits = new string[16]{
        //    "0000","0001","0010","0011","0100", "0101", "0110",
        //"0111", "1000","1001","1010", "1011", "1100", "1101", "1110","1111",};

        foreach (char n in num16)
        {
            //   for (int i = 0; i < 16; i++)
            // {
            switch (n)
            {
                case '0':
                    result = "0000" + result;
                    break;
                case '1':
                    result = "0001" + result;
                    break;
                case '2':
                    result = "0010" + result;
                    break;
                case '3':
                    result = "0011" + result;
                    break;
                case '4':
                    result = "0100" + result;
                    break;
                case '5':
                    result = "0101" + result;
                    break;
                case '6':
                    result = "0110" + result;
                    break;
                case '7':
                    result = "0111" + result;
                    break;
                case '8':
                    result = "01000" + result;
                    break;
                case '9':
                    result = "1001" + result;
                    break;
                case 'A':
                    result = "1010" + result;
                    break;
                case 'B':
                    result = "1011" + result;
                    break;
                case 'C':
                    result = "1100" + result;
                    break;
                case 'D':
                    result = "1101" + result;
                    break;
                case 'E':
                    result = "1110" + result;
                    break;
                case 'F':
                    result = "1111" + result;
                    break;
        }
    }
        return result;
    }

static void Main()
{
    Console.WriteLine("Enter a hexadecimal number: ");
    string input = Console.ReadLine();
    Console.WriteLine("This is the number in binary representation:\n\n" + ConvertHexadecimalToBinary(input));
}
}

