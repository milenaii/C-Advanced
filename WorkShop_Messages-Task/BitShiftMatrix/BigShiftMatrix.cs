using System;
using System.Linq;
using System.Numerics;

namespace BitShiftMatrix
{
    class BigShiftMatrix
    {
        static int rows;    // за да ги ползваме във вс методи
        static int cols;
        static int[] moves;
        static BigInteger[,] field;

        static void Main()
        {
            //read the input 
            rows = int.Parse(Console.ReadLine());
            cols = int.Parse(Console.ReadLine());
            int movesCount = int.Parse(Console.ReadLine());
            moves = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //second way
            //string[] moves2 = Console.ReadLine().Split(' ');

            //int[] arr = new int[moves2.Length];

            //for (int i = 0; i < moves2.Length; i++)
            //{
            //    arr[i] = int.Parse(moves2[i]);
            ////}

            field = new BigInteger[rows, cols];
            FillMatrix();  // може да не му подаваме матрицата 
                           //т.к. отгоре static си я четем

            BigInteger sum = 0;
            //Как да пазим позицията на която сме - или масив с две променливи
            int[] pos = { rows - 1, 0 };
            // или с две отделни променливи
            //int currentRow;
            //int currentCol;

            int coef = rows > cols ? rows : cols;
            //int coef2 = Math.Max(rows, cols);

            //Трябва да изчислим за всяко движение до кой ред и колона ще стигнем
            // т. е. обхождане на moves: foreach

            sum += field[pos[0], pos[1]]; // ако съм на 0,0 и искам да отида на 0,0 - тр да се сетим сами
            field[pos[0], pos[1]] = 0;  // защото не искаме да се повтарят - имаме 0, като я събере ние сме ок 

            foreach (var code in moves)
            {
                int[] tarPos = { code / coef, code % coef };
                //обхождайки тр да сумираме цифрите,к са там:

                int stepRow = pos[0] == tarPos[0] ? 0 : (pos[0] < tarPos[0] ? 1 : -1 );  // ако тр да отида наляво ред -1 или 1
                int stepCol = pos[1] == tarPos[1] ? 0 : (pos[1] < tarPos[1] ? 1 : -1);  // аналог кол, равното не го ползваме
                // 2 way
               // int stepRow = Math.Sign(tarPos[0] - pos[0]);
               // int stepCol = Math.Sign(tarPos[1] - pos[1]); 

                // Math.Sign(a - b) ->  1 -> a > b,
                //                  ->  0 -> a = b,
                //                  -> -1 -> a < b
                do
                {
                    pos[1] += stepCol;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;
                    
                } while (pos[1] != tarPos[1]);  // докато поз на кол е != от таргет кол
                //while (pos[1] != tarPos[1] && pos[1] >= 0 && pos[1] < cols) + гаранц,
                // че сме в матрицата 
                do
                {
                    pos[0] += stepRow;
                    sum += field[pos[0], pos[1]];
                    field[pos[0], pos[1]] = 0;
                    
                } while (pos[0] != tarPos[0]);

            }

            Console.WriteLine(sum);
        }

        private static void PrintMatrix(BigInteger[,] board)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write("{0,4}", board[r, c]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix()
        {
            for (int r = 0; r < rows; r++)  // 2 way with Field.GetLength
            {
                for (int c = 0; c < cols; c++)
                {
                    field[r, c] = (BigInteger)(1) << (rows - 1 - r + c); // 2 на степен нещо - побитово отместване
                }
            }
        }
    }
}
