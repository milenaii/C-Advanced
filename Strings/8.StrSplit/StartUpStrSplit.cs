using System;

namespace _8.StrSplit
{
    class StartUpStrSplit
    {
        static void Main()
        {
            string numbers2 = "1,, 2,3,       10 17,   333 66";
            string[] separedNumbers2 = numbers2.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string num in separedNumbers2)
            {
                Console.Write(num);
            }
            Console.WriteLine();
            string[] separedNumbers3 = numbers2.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string n in separedNumbers3)
            {
                Console.Write(n);
            }

        }
    }
}
