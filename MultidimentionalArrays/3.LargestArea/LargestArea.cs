using System;

class LargestArea
{
    static void Main()
    {
        // Declare and initialize matrix

        int[,] m = {
                { 0, 2, 4, 0, 9, 5 },
                { 7, 1, 3, 3, 2, 1 },
                { 1, 3, 9, 8, 5, 6 }
        };

        // Find the maximum sum ares 2x2

        int maxSum = int.MinValue;

        int maxRow = 0;    // ако искаме числата
        int maxCol = 0;    // ако искаме числата

        for (int r = 0; r < m.GetLength(0) - 1; r++)  // 3
            // тр да е минус едно, заради последните елементи в редовете
        {
            for (int c = 0; c < m.GetLength(1) - 1; c++)  // 6
            {
                int sum = m[r, c] + m[r, c + 1] + m[r + 1, c] + m[r + 1, c + 1];

                if (maxSum < sum)
                {
                    maxSum = sum;
                    maxRow = r;  // ако искаме числата
                    maxCol = c;  // ако искаме числата
                }

            }   // breakpoint + f5 за да проверя първата сума дали е ок
        }

        // print the results
        Console.WriteLine(maxSum);

        // ако искаме числата
        Console.WriteLine("{0} {1}", m[maxRow, maxCol], m[maxRow, maxCol + 1]);
        Console.WriteLine("{0} {1}", m[maxRow + 1 , maxCol],m[maxRow + 1 , maxCol + 1]);

    }
}

