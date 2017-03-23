using System;
//Write methods to calculate minimum, maximum, average, sum and product
//of given set of integer numbers. Use variable number of arguments.
//Write a program that reads 5 elements and prints their minimum, maximum,
//average, sum and product.

namespace _14.IntegerCalculations
{
    class IntegerCalculationsss
    {
        static int CalculateMinValue(params int[] numbers)
        {
            int min = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        static int CalculateMaxValue(params int[] numbers)
        {
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        static int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        static float CalculateAverage(params int[] numbers)
        {
            float sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            float ave = sum / (numbers.Length);
            return ave;
        }

        static int CalculateProduct(params int[] numbers)
        {
            int product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }
            return product;
        }


        static void Main()
        {
            Console.WriteLine("The min is " + CalculateMinValue(-1, 2, 3, 4, 10));
            Console.WriteLine("The max is " + CalculateMaxValue(-1, 2, 3, 4, 10));
            Console.WriteLine("The sum is " + CalculateSum(-1, 2, 3, 4, 10));
            Console.WriteLine("The average is {0:0.00}", CalculateAverage(-1, 2, 3, 4, 10));
            Console.WriteLine("The product is " + CalculateProduct(-1, 2, 3, 4, 10));
            Console.WriteLine((float)18/5);
            
        }
    }
}
