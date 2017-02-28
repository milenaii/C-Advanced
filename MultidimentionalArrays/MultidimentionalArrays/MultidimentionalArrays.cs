using System;
class MultidimentionalArrays

{
    static void Main()
    {

        int[] nums = { 111, 112, 113 };

        int[,] matrix = {
            {1, 2, 3 },
            {4, 5, 6}
        };

        int [,] orherMatrix = new int[3, 4];

        int[,,] cubeOne = new int[3, 3, 3];

        int[,,] cube = {
            {
                {1,2,3 },
                {4,5,6 }
            },
            {   
                {7,8,9 },
                {10,11,12 }
            }
        }; 
        


        Console.WriteLine(cube[0, 2, 2]);
        // 1  BREAKPOINT
        // 2  START WITH DEBUG F5
        //MENU   DEBUG-WINDOWS-LOCALS-TRIMEREN CUB NADOLU - 
        //WE CAN SEE ALL ELEMENTS

    }
}

