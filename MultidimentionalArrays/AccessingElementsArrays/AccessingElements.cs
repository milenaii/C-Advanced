using System;

class AccessingElements
{
    private static int pesho;

    static void Main()
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

        Console.WriteLine(matrix[1, 1]);  // 5

        int[,] matrixOne = { { 11, 12, 13 }, { 14, 15, 16 } };

        Console.WriteLine(matrixOne.Length);   // 6 - number of all elements
        Console.WriteLine(matrixOne.GetLength(0));  // 2 - rows
        Console.WriteLine(matrixOne.GetLength(1)); // 3 - coloums

        // accessing all elements of matrix
        Console.WriteLine("Accessing all elements of matrix: ");
        Console.WriteLine();

        for (int row = 0; row < matrixOne.GetLength(0); row++)
        {
            for (int col = 0; col < matrixOne.GetLength(1); col++)
            {
                Console.WriteLine(matrixOne[row, col]);
            }
        }

        //Accessing all elements of cube
        Console.WriteLine("Access all elements of cube: ");
        Console.WriteLine();

        int[,,] cube = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

        for (int width = 0; width < cube.GetLength(0); width++)
        {
            for (int length = 0; length < cube.GetLength(1); length++)
            {
                for (int height = 0; height < cube.GetLength(2); height++)
                {
                    Console.WriteLine(cube[width, length, height]);
                }
            }

        }

        // 4 мерен масив

        int[,,,] mimi = { { { {1,2,3 },{4,5,6 }  },{ {7,8,9 },
{10,11,12 } },
            { {13,14,15 },
            {16,17,18 } } } };


    }
}

