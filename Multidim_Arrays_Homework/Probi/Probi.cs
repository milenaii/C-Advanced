using System;
class Probi
{
    static void Main()
    {
        int n = 4;
        int[,] mi = new int[n, n];

        int count = 1;
        int row = 0;
        int col = 0;

        // for (int r = 0; r < n; r++)


        // From position [0,0], we are going down n times:
        for (int i = 0; i < n; i++)
        {
            col = 0;
            row = i;
            mi[row, col] = count++;
        }
        // From position [n,0], we are going right n-1 times:
        for (int i = 1; i < n; i++)
        {
            col = i;
            row = n - 1;
            mi[row, col] = count++;
        }
        // From position [n,n], we are going up n - 1 times:
        for (int i = n - 2; i >= 0; i--)
        {
            col = n - 1;
            row = i;
            mi[row, col] = count++;
        }

        // From position [0,n], we are going left n-2 times:
        for (int i = n - 2; i >= 1; i--)
        {
            col = i;
            row = 0;
            mi[row, col] = count++;
        }
        // From position [0,n-2], we are going down n-2 times:
        for (int i = 1; i < n - 1; i++)
        {
            row = i;
            col = 1;
            mi[row, col] = count++;
        }


        // Print the results

        for (int rw = 0; rw < n; rw++)
        {
            for (int cl = 0; cl < n; cl++)
            {
                Console.Write(mi[rw, cl] + "  ");
            }
            Console.WriteLine();
        }
    }
}


