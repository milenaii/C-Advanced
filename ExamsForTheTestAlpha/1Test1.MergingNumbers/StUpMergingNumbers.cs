using System;

namespace _1Test1.MergingNumbers
{
    class StUpMergingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int[] merge = new int[n - 1];
            int[] sum = new int[n - 1];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
            {
                int b = arr[i] % 10;
                int c = arr[i + 1] / 10;
                merge[i] = b * 10 + c;

                sum[i] = arr[i] + arr[i + 1]; 
            }
            Console.WriteLine(string.Join(" ",merge));
            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
