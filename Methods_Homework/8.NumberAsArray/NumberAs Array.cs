using System;
//Write a method that adds two positive integer numbers represented
//as arrays of digits(each array element arr[i] contains a digit;
//the last digit is kept in arr[0]). Write a program that reads two
//arrays representing positive integers and outputs their sum.

namespace _8.NumberAsArrayyy
{
    class Program
    {
        static string AddsTwoPositivesNumbersAsArrays(int[] arr1, int[] arr2)
        {
            int l1 = arr1.Length;
            int l2 = arr2.Length;
            
            //1
            if (l1 < l2)
            {
                int[] arrSum = new int[l2];

                for (int i = 0; i < l2; i++)
                {

                    if (i <= l1 - 1)
                    {
                        arrSum[i] += (arr1[i] + arr2[i]) % 10;
                        arrSum[i + 1] += (arr1[i] + arr2[i]) / 10;
                    }

                    else if ((l1 <= i) && (i <= l2 - 1))
                    {
                        arrSum[i] = arr2[i];
                    }
                }
                for (int i = 0; i < l2; i++)
                {
                    Console.Write(arrSum[i] + " ");
                    Console.WriteLine();
                }
            }

            //2
            if (l1 > l2)
            {
                int[] arrSum = new int[l1];

                for (int i = 0; i < l1; i++)
                {

                    if (i <= l2 - 1)
                    {
                        arrSum[i] += (arr1[i] + arr2[i]) % 10;
                        arrSum[i + 1] += (arr1[i] + arr2[i]) / 10;
                    }

                    else if ((l2 <= i) && (i <= l1 - 1))
                    {
                        arrSum[i] = arr1[i];
                    }
                }
                for (int i = 0; i < l1; i++)
                {
                    Console.Write(arrSum[i] + " ");
                    Console.WriteLine();
                }
            }
            //3
            else if (l1 == l2)
            {
                int[] arrSum = new int[l1];

                for (int i = 0; i < l1; i++)
                {
                    if (i == l1 - 1)
                    {
                        arrSum[i] += (arr1[i] + arr2[i]) % 10;
                    }
                    else if (i != l1 - 1)
                    {
                        arrSum[i] += (arr1[i] + arr2[i]) % 10;
                        arrSum[i + 1] += (arr1[i] + arr2[i]) / 10;
                    }
                }
                for (int i = 0; i < l2; i++)
                {
                    Console.Write(arrSum[i] + " ");
                    Console.WriteLine();
                }
            }
            return "";
        }

        static void Main()
        {
            // read the input data
            Console.WriteLine("Enter two numbers separated by spaces\n- the size of each array: ");

            string [] len = Console.ReadLine().Split(' '); 
            int l1 = int.Parse(len[0]);
            int l2 = int.Parse(len[1]);

            Console.WriteLine("Enter the first array: ");
            string [] firstArr = Console.ReadLine().Split(' ');
            int[] arr1 = new int[l1];

            for (int i = 0; i < l1; i++)
            {
                arr1[i] = int.Parse(firstArr[i]);
            }

            Console.WriteLine("Enter the second array: ");
            string[] secondArr = Console.ReadLine().Split(' ');
            int[] arr2 = new int[l2];

            for (int i = 0; i < l2; i++)
            {
                arr2[i] = int.Parse(secondArr[i]);
            }

            //Call the method
            Console.Write(AddsTwoPositivesNumbersAsArrays(arr1, arr2));

            // Print result is not on the single line
        }
    }
}
