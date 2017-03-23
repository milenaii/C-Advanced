using System;
//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a* x + b = 0
namespace _13.SolveTasks
{
    class SolveTasksss
    {
        static string ReverseDigitInNumber(int number)
        {
            string result = "";

            while (number != 0)
            {
                result += (number % 10).ToString();
                number /= 10;
            }
            return result;
        }

        static float SolveLinearEquetion(float a, float b)
        {
            if (a != 0)
            {
                // a*x + b = 0
                float x = -(b / a);
                return x;
            }
            else
            {
                Console.WriteLine("a must be not equal to 0");
                return 00;
            }

        }


        static int CalculatesAverage(int count, params int[] numbers)
        {
            int average = 0;
            for (int i = 0; i < count; i++)
            {
                average += numbers[i];
            }
            average = average / count;

            return average;
        }


        static void Main()
        {
            Console.WriteLine(CalculatesAverage(5, 4, 2, 3, 2, 4));
            Console.WriteLine(SolveLinearEquetion(2, -5));
        }
    }
}
