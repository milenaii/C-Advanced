using System;
//We are given a matrix of strings of size N x M.Sequences in the matrix
//we define as sets of several neighbour elements located on the same line,
//column or diagonal.Write a program that finds the longest sequence of equal
//strings in the matrix and prints its length.

class SequenceInMatrix
{
    static void Main()
    {
        //Reading the input

        string[] input = Console.ReadLine().Split(' ');

        int n = int.Parse(input[0]);
        int m = int.Parse(input[0]);

        string[,] mi = new string[n, m];

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split(' ');
            for (int j = 0; j < m; j++)
            {
                mi[i, j] = input[j];
            }
        }

        ////Proba
        //int[,] mi = { { 92, 11, 23, 42, 59, 48 }, { 09, 92, 23, 72, 56, 14 },
        //    { 17, 63, 92, 46, 85, 95 }, {34, 12, 52, 69, 23, 95 },
        //    {26, 88, 78, 71, 29, 95 }, {26, 88, 78, 71, 29, 95 } };
        //int n = mi.GetLength(0);
        //int m = mi.GetLength(1);


        // Find the max sequence
        int sequence = 1;
        int maxSeq = int.MinValue;

        // Check the elements of the rows
        for (int row = 0; row < n; row++)
        {
            sequence = 1;
            for (int col = 0; col < m - 1; col++)
            {
                if (mi[row, col] == mi[row, col + 1])
                {
                    sequence++;
                    if (maxSeq <= sequence)
                    {
                        maxSeq = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }
            }
        }

        //check the elements of the coloumns
        for (int col = 0; col < m; col++)
        {
            sequence = 1;
            for (int row = 0; row < n - 1; row++)
            {
                if (mi[row, col] == mi[row + 1, col])
                {
                    sequence++;
                    if (maxSeq <= sequence)
                    {
                        maxSeq = sequence;
                    }
                }
                else
                {
                    sequence = 1;
                }

            }
        }
        //Check elements of diagonale:left to right
        for (int row = 0; row < n - 1; row++)
        {
            sequence = 1;
            for (int col = 0; col < m - 1; col++)
            {
                if (mi[row, col] == mi[row + 1, col + 1])
                {
                    sequence++;
                    row++;
                    //col++;
                    if (row + 1 == n || col + 2 == m)
                    {
                        if (maxSeq <= sequence)
                        {
                            maxSeq = sequence;
                        }

                        goto Ready;
                    }
                    if (maxSeq <= sequence)
                    {
                        maxSeq = sequence;
                    }
                    else
                    {
                        sequence = 1;
                    }
                }
            }

        }
        Ready:;

        //Chech elements of diagonale: right to left
        for (int row = 0; row < n - 1; row++)
        {
            sequence = 1;
            for (int col = 1; col < m; col++)
            {
                if (mi[row, col] == mi[row + 1, col - 1])
                {
                    sequence++;
                    row++;
                    col = col - 2;
                    if (row + 1 == n)
                    {
                        if (maxSeq < sequence)
                        {
                            maxSeq = sequence;
                        }
                        goto Final;
                    }
                }
                if (maxSeq < sequence)
                {
                    maxSeq = sequence;
                }
                else
                {
                    sequence = 1;
                }
            }
        }
        Final:;

        //Print the result
        Console.WriteLine(maxSeq);

    }
}

