using System;

namespace _3.ConcatanatingStrings
{
    class Program
    {
        static void Main()
        {
            string sentence = "byah na lekcia" + " v4era";

            sentence += 10;  // 10
            sentence += new int[] { 1, 2, 3 };  // System.Int32[]
            sentence += true;        // True

            Console.WriteLine(sentence);
        }
    }
}
