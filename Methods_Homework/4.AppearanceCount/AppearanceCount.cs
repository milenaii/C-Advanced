using System;
//Write a method that counts how many times given number 
//appears in a given array. Write a test program to check if the
//method is working correctly.

namespace _4.AppearanceCount
{
    class AppearanceCounttt
    {
        static int AppearanceCountInArray(int[] array, int num)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (num == array[i])
                {
                    count++;
                }
            }

            return count;
        }


        static void Main()
        {
            Console.WriteLine("Enter a number N - the size of the array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter N numbers separated by spaces -the numbers in the array");

            string[] inputArray = Console.ReadLine().Split(' ');

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(inputArray[i]);
            }

            Console.WriteLine("Enter a number X - how many times it appears");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(AppearanceCountInArray(arr, x));

        }
    }
}
