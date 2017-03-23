using System;
// Write a method that checks if the element at given position in 
//given array of integers is larger than its two neighbours (when such exist).
//Write program that reads an array of numbers and prints how many of
//them are larger than their neighbours.

namespace _5.LargerThanNeibours
{
    class LargerThanNeiboursss
    {
        static int CheckIfNumberLargerThanNeigbours(int [] array)
        {
            int count = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main()
        {
            Console.WriteLine("Enter a number N - the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter N numbers separated by spaces - the array: ");

            string[] inputArray = Console.ReadLine().Split(' ');

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(inputArray[i]);
            }

            Console.WriteLine(CheckIfNumberLargerThanNeigbours(arr));
        }
    }
}
