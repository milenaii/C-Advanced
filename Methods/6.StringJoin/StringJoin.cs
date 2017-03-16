using System;


namespace _6.StringJoin
{
    class StringJoinnn
    {
        static string Join(int[] numbers, string separator)
        {
            string result = "";

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                result += numbers[i] + separator;
            }
            result += numbers[numbers.Length - 1];

            return result;
        }

        static void Main()
        {
            int[] numbers = { 1, 2, 4, 45, 874 };
            Console.WriteLine(Join(numbers, " -> "));


        }
    }
}
