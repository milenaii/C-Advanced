using System;
//Write a class Matrix, to hold a matrix of integers. 
//Overload the operators for adding, subtracting and multiplying 
//of matrices, indexer for accessing the matrix content and ToString().

class MatrixClass
{
    static void Main()
    {
        ////int n = 3;
        //int[,] ma1 = new int[3, 3]
        //{ { 2, 3, 4 }, { 5, 6, 7 }, { 8, 9, 10 } };
        //int[,] ma2 = new int[3, 3]
        //    { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };


        ////Adding matrix - we can adding matrixes from the same type
        //int[,] mAdd = new int[3, 3];
        //// we can adding matrixes from the same type
        //if (ma1.GetLength(0) == ma2.GetLength(0) &&
        //    ma1.GetLength(1) == ma2.GetLength(1))
        //{
        //    for (int row = 0; row < mAdd.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < mAdd.GetLength(1); col++)
        //        {
        //            mAdd[row, col] = ma1[row, col] + ma2[row, col];
        //            //Print mAdd
        //            Console.Write(mAdd[row, col] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine();
        //}
        //else
        //{
        //    Console.WriteLine(" The matrixes are not from the same type");
        //}


        ////Substractig matrix
        //int[,] mSub = new int[3, 3];

        //if (ma1.GetLength(0) == ma2.GetLength(0) &&
        //    ma1.GetLength(1) == ma2.GetLength(1))
        //{
        //    for (int row = 0; row < mSub.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < mSub.GetLength(1); col++)
        //        {
        //            mSub[row, col] = ma1[row, col] - ma2[row, col];
        //            // Print mSub
        //            Console.Write(mSub[row, col] + "\t");
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine();
        //}
        //else
        //{
        //    Console.WriteLine(" The matrixes are not from the same type");
        //}


        //Multiplying matrix
        int[,] m1 = new int[3, 2] { { 1, 3 }, { 0, -2 }, { 4, 1 } };
        int[,] m2 = new int[2, 2] { { 7, 9 }, { 5, 2 } };

        int[,] mMult = new int[m1.GetLength(0), m2.GetLength(1)];

        // стълбовете на м1 === На редовете на м2
        if (m1.GetLength(1) == m2.GetLength(0))
        {
            for (int row = 0; row < m1.GetLength(0); row++)
            {
                for (int col = 0; col < m2.GetLength(1); col++)
                {
                    for (int k = 0; k < m1.GetLength(1); k++)
                    {
                        mMult[row, col] += m1[row, k] * m2[k, col];
                    }
                }
            }
        }
        // като се разпише и се проследи с Дебъг става по-ясно
        // m[0,0] = m1[0,0] * m2[0,0]  +  m1[0,1] * m2[1,0] 
        // m[0,1] = m1[0,0] * m2[0,1]  +  m1[0,1] * m2[1,1] 
        // m[1,0] = m1[1,0] * m2[0,0]  +  m1[1,1] * m2[1,0] 
        // m[1,1] = m1[1,0] * m2[0,1]  +  m1[1,1] * m2[1,1] 
        // m[2,0] = m1[2,0] * m2[0,0]  +  m1[2,1] * m2[1,0] 
        // m[2,1] = m1[2,0] * m2[0,1]  +  m1[2,1] * m2[1,1] 
        
        //к ни трябва за втората част на матричния елемент


        else
        {
            Console.WriteLine(" The matrixes are not from the same type");
        }

        //Print mMult
        for (int row = 0; row < mMult.GetLength(0); row++)
        {
            for (int col = 0; col < mMult.GetLength(1); col++)
            {
                Console.Write(mMult[row, col] + " \t");
            }
            Console.WriteLine();
        } 

    }
}

