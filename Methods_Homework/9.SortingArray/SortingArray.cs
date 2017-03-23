using System;
//Write a method that returns the maximal element in a portion of array
//of integers starting at given index. Using it write another method that
//sorts an array in ascending / descending order. Write a program that
//sorts a given array.

namespace _9.SortingArray
{
    class SortingArrayyy
    {
        static int FindMaxNumberInArray(int[] array)
        {

            int max = int.MinValue;
            int maxIndex = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static int FindMaxNumberInPortionOfArrayStartOfIndex(int[] array, int index)
        {

            int max = int.MinValue;
            int maxIndex = int.MinValue;

            for (int i = index; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        static void SortArrayDecending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                //намери макс, размени го с 0 
                //от 1 до края намери макс, размени го с 1
                //от 2 до края намери макс, размени го с 2 ....

                // Find max
                int maxInd = FindMaxNumberInPortionOfArrayStartOfIndex(array, i);
                //Console.WriteLine("{0}, {1}", i, maxInd);

                //replace max and i
                int temp = array[i];
                array[i] = array[maxInd];
                array[maxInd] = temp;
            }
        }

        static void SortArrayAscendingPrint(int[] sortDecArray)
        {
            int[] sortAsceArray = new int[sortDecArray.Length];

            for (int i = 0; i < sortDecArray.Length; i++)
            {
                sortAsceArray[i] = sortDecArray[sortDecArray.Length - 1 - i];
                Console.Write(sortAsceArray[i] + " ");
            }
            Console.WriteLine();
        }

        static void PrintArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] +" ");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            //Read the input data
            int l = int.Parse(Console.ReadLine());
            int[] mi = new int[l];

            string [] input = Console.ReadLine().Split(' ');

            for (int i = 0; i < l; i++)
            {
                mi[i] = int.Parse(input[i]);
            }
            //int[] mi = { 3, 1, 24, 5, 55, 48 };

            //Console.WriteLine(FindMaxNumberInArray(mi));
            //Console.WriteLine(FindMaxNumberInPortionOfArrayStartOfIndex(mi, 5));

            Console.WriteLine();

            
            PrintArray(mi);
            SortArrayDecending(mi);
            PrintArray(mi);
            SortArrayAscendingPrint(mi);
            
        }


    }
}
