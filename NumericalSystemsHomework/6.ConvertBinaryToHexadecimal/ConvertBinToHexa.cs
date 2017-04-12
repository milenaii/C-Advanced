using System;

class ConvertBinToHexaaa
{
    static string ConvertBinToHexa(string numBin)
    {
        string result = "";

        for (int i = 0; i < numBin.Length; i = i + 4)
        {
            switch (numBin.Substring(i, 4))
            {
                case "1010": result = result + 'A'; break;
                case "1011": result = result + 'B'; break;
                case "1100": result = result + 'C'; break;
                case "1101": result = result + 'D'; break;
                case "1110": result = result + 'E'; break;
                case "1111": result = result + 'F'; break;
                case "0000": result = result + '0'; break;
                case "0001": result = result + '1'; break;
                case "0010": result = result + '2'; break;
                case "0011": result = result + '3'; break;
                case "0100": result = result + '4'; break;
                case "0101": result = result + '5'; break;
                case "0110": result = result + '6'; break;
                case "0111": result = result + '7'; break;
                case "1000": result = result + '8'; break;
                case "1001": result = result + '9'; break;
               
            }

        }

        return result;
    }
    static void Main()
    {
        cw
    }
}

