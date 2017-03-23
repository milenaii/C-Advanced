using System;
//Write a method that returns the index of the first element in 
//array that is larger than its neighbours, or -1, if there is no such element.

namespace _6.FirstLargersThanNeigbourssss
{
    class FirstLargerThanNeigbours
    {
        static int FindFirstNumberLargerThanNeigbours(int[] array)
        {
            for (int i = 1; i < array.Length - 1; i++)
            {
                if ((array[i] > array[i - 1]) && (array[i] > array[i + 1]))
                {
                    return i;
                }
            }
            return -1;
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

            Console.WriteLine(FindFirstNumberLargerThanNeigbours(arr));
        }
    }
}