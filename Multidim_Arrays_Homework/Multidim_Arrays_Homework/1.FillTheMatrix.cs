using System;

//FILL THE MATRIX

//Write a program that fills and prints a matrix of size (n, n) as shown below.
class FillTheMatrix

{
    static void Main()
    {
        // input - 2 lines - number and a,b,c or d
        int n = int.Parse(Console.ReadLine());  // ex:    3 
                                                //        a
        int[,] mi = new int[n, n];

        string index = Console.ReadLine();

        if (index == "a")
        // matrix from this type:  1 2 3 / 4 5 6 / 7 8 9
        {
            int counter = 1;
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                   // MImi decigion - it works
                    // mi[row, col] = row + 1 + col * n;
                    mi[row, col] = counter++;
                }
            }
        }

        else if (index == "b")
        //Matrix from this tipe:  1 2 3 / 6 5 4 / 7 8 9
        {

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (col % 2 == 0)
                    {
                        mi[row, col] = (row + 1) + col * n;
                    }
                    else if (col % 2 != 0)
                    {
                        mi[row, col] = (col + 1) * n - row;
                    }
                }
            }
        }

        else if ((index == "c"))
        //Matrix from this tipe:  4 7 9 / 2 5 8 / 1 3 6
        {
            int count = 1;
            int col = 0;
            int row = 0;
            // Populate values under the main diagonal
            for (int i = n - 1; i >= 0; i--)
            {
                row = i;
                col = 0;    // всеки път като върти, колоната да е 0
                while ((row < n) && (col < n))
                {
                    mi[row++, col++] = count;
                    count++;
                }
            }

            //Populates values over the main diagonale

            for (int j = 1; j < n; j++)
            {
                col = j;
                row = 0;
                while (row < n && col < n)
                {
                    mi[row++, col++] = count;
                    count++;
                }
            }
        }



        //Print the results
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(mi[row, col] + "  ");
            }
            Console.WriteLine();
        }

       
    }
}

