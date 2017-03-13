using System;
//Write a program that reads a rectangular matrix of size N x M and finds 
// in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

class Program
{
    static void Main()
    {
        //Reading the input data

        string[] input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
    
        int[,] mi = new int[n, m];

        for (int row = 0; row < n; row++)
        {
            input = Console.ReadLine().Split(' ');
            for (int col = 0; col < m; col++)
            {
                mi[row, col] = int.Parse(input[col]);
            }
        }
        //Find square 3x3 that has max sum

        int sum = int.MinValue;
        int maxSum = int.MinValue;

        for (int row = 0; row < mi.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < mi.GetLength(1) - 2; col++)
            {
                sum = mi[row, col] + mi[row + 1, col + 1] + mi[row + 1, col] + mi[row, col + 1] +
                    +mi[row, col + 2] + mi[row + 1, col + 2] + mi[row + 2, col] +
                    +mi[row + 2, col + 1] + mi[row + 2, col + 2];

                if (maxSum <= sum)
                {
                    maxSum = sum;
                }
            }
        }

        //Print the result
        Console.WriteLine(maxSum);

    }
}

