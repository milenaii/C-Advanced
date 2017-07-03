using System;
using System.Collections.Generic;


namespace PapperCutter
{
    class StUpPapperCutter
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] a = new int[] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024 };
            string[] sheet = new string[] { "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0" };

            List<string> output = new List<string> { "A10", "A9", "A8", "A7", "A6", "A5", "A4", "A3", "A2", "A1", "A0" };
            
            {
                for (int i = a.Length - 1; i >= 0; i--)
                {
                    if (n == 2046)
                    {
                        Console.WriteLine("A10");
                    }
                    if (((n) - a[i]) == 0)
                    {
                        output.Remove(sheet[i]);
                        Console.WriteLine(String.Join("\n", output));
                        break;
                    }
                    else if ((n - a[i]) > 0)
                    {
                        string st = sheet[i];
                        output.Remove(st);
                        n = n - a[i];
                    }
                }

            }

        }
    }
    //}
}
