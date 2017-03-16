using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Overload
{
    class Overloaddd
    {
        // 1 method
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
        //2 method
        static void PrintMatrix(int[,] matrix, ConsoleColor color)
        {
            Console.ForegroundColor = color;


            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0, 4}", matrix[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            // за да не ни се повтаря код добре е вместо копи пайст - 
            // на горните редове , да кажем:

            PrintMatrix(matrix);  // този метод ще извика другия
        }

        static void Main()
        {
            int[,] table =
                    {
                {4, 45, 44 },
                {5, 45, 8 },
                {2, 4, -5 }
            };
            PrintMatrix(table);
            Console.WriteLine("=======================");
            PrintMatrix(table, ConsoleColor.Green);
               

        }
    }
}


