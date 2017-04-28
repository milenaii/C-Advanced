using System;
//You are given a sequence of positive integer values
//written into a string, separated by spaces. Write a function 
//that reads these values from given string and calculates their sum. 
//Write a program that reads a string of positive integers separated
//by spaces and prints their sum.
namespace _8.SumIntegers
{
    class SumIntegers
    {

        static int CalculateSum(string array)
        {
            string[] num = array.Split(' ');
            int sum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                sum += int.Parse(num[i]);
            }

            return sum;
        } 

        static void Main()
        {
            Console.WriteLine("Enter some integers diveded by spaces: ");
            string arr = Console.ReadLine();

            Console.WriteLine(CalculateSum(arr));
           

        }
    }
}
