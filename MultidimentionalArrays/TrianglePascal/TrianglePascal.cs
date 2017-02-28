using System;

class TrianglePascal
{
    static void Main()
    {
        int n = 10;
        int[][] triangle = new int[n][];

        int num = 1;

        for (int row = 0; row < n; row++)
        {
            triangle[row] = new int[row + 1];  // 0 row - 1 elem; 1 row - 2 elem ....
            for (int col = 0; col < triangle[row].Length; col++)
            {
                triangle[row][col] = num;
                num++;
            }
        }

        // Print the result

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < triangle[row].Length; col++)
            {
                Console.Write("{0}, ", triangle[row][col]);
            }
            Console.WriteLine();  // за да се получи триъгълника
        }

        // similarly
        //for (int row = 0; row < n; row++)
        //{
        //    Console.WriteLine(string.Join(", ", triangle[row]));
        //}


    }//breakpoint + f5, to check if the programs work ok
}

