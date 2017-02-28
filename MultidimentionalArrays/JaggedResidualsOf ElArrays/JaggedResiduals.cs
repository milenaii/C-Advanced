using System;
using System.Collections.Generic;

class JaggedResiduals
{
    static void Main()
    {
        int[] nums = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };

        List<int>[] jagged = new List<int>[3];

        for (int i = 0; i < jagged.Length; i++)
        {
            jagged[i] = new List<int>(); // трябва да инициализираме вътрешните листове
        }

        for (int i = 0; i < nums.Length; i++)  // вместо този цикъл може
                                                // долния
        {
            if ((nums[i] % 3) == 0)
            {
                jagged[0].Add(nums[i]);
            }
            else if ((nums[i] % 3) == 1)
            {
                jagged[1].Add(nums[i]);
            }
            else if ((nums[i] % 3) == 2)
            {
                jagged[2].Add(nums[i]);
            }
        }

        // или вместо ифовете :
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    int index = nums[i] % 3;
        //    jagged[index].Add(nums[i]);
        //}


        for (int i = 0; i < jagged.Length; i++)
        {
            Console.WriteLine(string.Join(" , ", jagged[i]));
        }


    }
}

