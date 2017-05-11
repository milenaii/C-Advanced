using System;
using System.Text;

namespace _16.StringBuilderrr
{
    class ProgramStartUpStringBuilder
    {
        static string Repeat(char c, int count)
        {
            StringBuilder result = new StringBuilder();
            while (count > 0)
            {
                result.Append(c);
                result.AppendFormat("---{0}---", c);
                count--;
            }
            return result.ToString();
        }

        static void Main()
        {
            Console.WriteLine(Repeat('*',40));
        }
    }
}
