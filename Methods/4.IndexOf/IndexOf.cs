using System;

namespace _4.IndexOf
{
    class IndexOfff
    {
        static int IndexOf(char[] symbols, char seekedValue)
        {
            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == seekedValue)
                {
                    return i;
                }
            }

            return -1;
        }

        static void Main()
        {
            char[] symbols = "az sym kon".ToCharArray();

            int indexOfO = IndexOf(symbols, 'o');
            int indexOfM = IndexOf(symbols, 'm');
            int indexOfM1 = IndexOf(symbols, 'M');
            int indexOfT = IndexOf(symbols, 't');

            Console.WriteLine("o -> {0}", indexOfO);
            Console.WriteLine("m -> {0}", indexOfM);
            Console.WriteLine("M -> {0}", indexOfM1);
            Console.WriteLine("t -> {0}", indexOfT);







        }
    }
}
