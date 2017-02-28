using System;
class JaggedRes

    // трябва да я огледам, не ми е много ясно
{
    static void Main()
    {
        int[] numbers = { 0, 1, 4, 113, 55, 3, 1, 2, 66, 557, 124, 2 };
        int[] sizes = new int[3];  // 
        int[] offsets = new int[3];

        //check how much of elements of numbers have residual 0, 1 or 2
        // the number of them must be == to dimension of the secondary arrays

        foreach (var number in numbers)
        {
            int remainder = number % 3;  // 0, 1, or  2
            sizes[remainder]++;
        }

        int[][] numbersByRemainder = new int[3][]
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            int index = offsets[remainder];
            numbersByRemainder[remainder][index] = number;
            offsets[remainder]++;

        }
    }
}

