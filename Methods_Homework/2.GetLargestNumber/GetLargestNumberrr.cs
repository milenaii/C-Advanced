using System;
//Write a method GetMax() with two parameters that returns the larger 
//of two integers.Write a program that reads 3 integers from the console
//and prints the largest of them using the method GetMax().

namespace _2.GetLargestNumber
{
    class GetLargestNumberrr
    {
        static int GetMax(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
            return b;
            }        
        }

        static void Main()
        {

            Console.WriteLine( "On the first line you will receive"
                + " 3 integers separated by spaces");
            //Read the input

            string [] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            // Call the GetMax and print the result
            Console.WriteLine(GetMax(GetMax(a,b),c));
            
        }
    }
}
