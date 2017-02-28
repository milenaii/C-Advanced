using System;
class CubeSetElements
{
    static void Main()
    {
        int[,,] cube = new int[2, 3, 4];

        int num = 1;

        for (int w = 0; w < cube.GetLength(0); w++)
        {
            for (int h = 0; h < cube.GetLength(1); h++)
            {
                for (int d = 0; d < cube.GetLength(2); d++)
                {
                    cube[w, h, d] = num;
                    num++;
                    Console.WriteLine(cube[w, h, d]);
                }
            }
        }
        // Print on the console
        for (int w = 0; w < cube.GetLength(0); w++)
        {
            Console.WriteLine(" { ");
            for (int h = 0; h < cube.GetLength(1); h++)
            {
                Console.Write(" { ");
                for (int d = 0; d < cube.GetLength(2); d++)
                {
                    Console.Write("{0,4}", cube[w, h, d]);
                }
                Console.WriteLine(" }");
            }
            Console.WriteLine(" }");
        }

    }
}

