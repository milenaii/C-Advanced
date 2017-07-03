using System;

namespace Enam_Alpha
{
    class MazeRunner
    {
        static void Main()

        {
            int n = int.Parse(Console.ReadLine());
            string result = "";
            string[] res = new string[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int fourDig = num % 10;
                int thirdDig = (num / 10) % 10;
                int secDig = (num / 100) % 10;
                int firstDig = (num / 1000) % 10;

                int sumEven = 0;
                int sumOdd = 0;

                if (firstDig % 2 == 0)
                {
                    sumEven += firstDig;
                }
                else
                {
                    sumOdd += firstDig;
                }
                if (secDig % 2 == 0)
                {
                    sumEven += secDig;
                }
                else
                {
                    sumOdd += secDig;
                }
                if (thirdDig % 2 == 0)
                {
                    sumEven += thirdDig;
                }
                else
                {
                    sumOdd += thirdDig;
                }
                if (fourDig % 2 == 0)
                {
                    sumEven += fourDig;
                }
                else
                {
                    sumOdd += fourDig;
                }

                if (sumEven > sumOdd)
                {
                    res[i] = "left";
                    //Console.WriteLine("left");
                    //result += "left\n";
                }
                else if (sumOdd > sumEven)
                {
                    res[i] = "right";
                    //Console.WriteLine("right");
                    //result += "right\n";
                }
                else if (sumOdd == sumEven)
                {
                    res[i] = "straight";
                    //Console.WriteLine("straight");
                    //result += "straight\n";
                }

            }
            
            Console.WriteLine(string.Join("\n", res));

        }
    }
}
