using System;

class MethodOfArray

{
    static void Main()
    {
        int[] nums = { 5, 6, 3, 7, 2, 1, 5, 6, 4 };

        Console.WriteLine(Array.IndexOf(nums,6)); //1

        Console.WriteLine(Array.LastIndexOf(nums,6)); //7

        // Lets make IndexOf by ourselves:

        int searchNum = 6;

        int index;
        for (index = 0; index < nums.Length ; index++)
        {
            if (nums[index] == searchNum)
            {
                break;
            }
        }
        Console.WriteLine(index);

        // Lets make IndexOf by ourselves:

        int searchN = 6;

        int ind;
        for (ind = nums.Length - 1; ind >= 0; ind--)
        {
            if (nums[ind] == searchN)
            {
                break;
            }
        }
        Console.WriteLine(ind);


    }
}

