using System;

namespace Matrices
{
    class StartUp
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            int[,] matrix =
                {
                { 1, 2, 3, 4, 5 },
                {6, 1 , 23, 45, -15 },
                {23, 24, 4, 55, -4 }
            };
            int[,] table =
                    {
                {4, 45, 44 },
                {5, 45, 8 },
                {2, 4, -5 }
            };
            PrintMatrix(matrix);
            Console.WriteLine("=======================");
            PrintMatrix(table);


        }
    }
}
