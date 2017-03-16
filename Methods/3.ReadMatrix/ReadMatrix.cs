using System;

namespace ReadMatrix
{
    class ReadingMatrices
    {
        static int[,] ReadMatrix(int rows, int cols)
        {
            int[,] result = new int[rows, cols];

            //read the matrix
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return result;
        }


        static void Main()
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[,] mi = ReadMatrix(r, c);

            //Print
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("{0, 4}", mi[i,j]);
                }
                Console.WriteLine();
            }


        }
    }
}
