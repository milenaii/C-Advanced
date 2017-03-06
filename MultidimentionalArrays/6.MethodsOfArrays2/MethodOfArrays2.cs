using System;
class MethodOfArrays2
{
    static void Main()
    {
        int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

        // Copy Array
        int[] copyArray = new int[7];

        Array.Copy(nums, copyArray, 7);
        Console.WriteLine("copy     " + string.Join(", ",copyArray));

        //Reverse Array

        Array.Reverse(nums);
        Console.WriteLine("reverse    " + string.Join(", ",nums));

        // Sort

        int[] unsortArr = { 4, 3, 4, 9, 5, 0, 2 };

        Array.Sort(unsortArr);
        Console.WriteLine("sort    " + string.Join(", ",unsortArr));


        Array.Reverse(unsortArr);
        Console.WriteLine("sort reverse   " + string.Join(", ", unsortArr));


        // Sort Array of strings - lexicographical

        string[] alphabet = { "A", "C", "Gb", "D", "F", "B", "E", "Ga", "Gc" };
        Array.Sort(alphabet);
        Console.WriteLine("sort strings   " + string.Join(", ", alphabet));

        Console.WriteLine();
    }
}

