using System;

namespace _4.MixingNumbers
{
    class StUpMixingNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int[] mix = new int[n - 1];
            int[] sub = new int[n - 1];


            for (int i = 0; i < n - 1; i++)
            {
                //mixing numbers
                int b = arr[i] % 10;
                int c = arr[i + 1] / 10;

                mix[i] = b * c;

                if (arr[i] >= arr[i + 1])
                {
                    sub[i] = arr[i] - arr[i + 1];
                }
                else
                {
                    sub[i] = arr[i + 1] - arr[i];
                }
            }
            Console.WriteLine(string.Join(" ", mix));
            Console.WriteLine(string.Join(" ", sub));

            
        }
    }
}
