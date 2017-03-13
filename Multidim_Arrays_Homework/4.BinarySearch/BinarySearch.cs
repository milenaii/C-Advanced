using System;
//Write a program, that reads from the console an array of N integers
//and an integer K, sorts the array and using the method Array.BinSearch() 
//finds the largest number in the array which is ≤ K. 
class BinarySearch
{
    static void Main()
    {
        int[] bfm = { 16, 1, 3, 5, 8, 4, 13 };
        int k = 31;  // up to 31 works OK, заради паметта, която е заделена 
                     //за масива, която е 32 -> 0....31
        int result;

        Array.Sort(bfm);

        //Print sorted array
        for (int i = 0; i < bfm.Length; i++)
        {
            Console.Write(bfm[i] + ", ");
        }
        Console.WriteLine();
        //

        for (int i = 0; i < k; i++)
        {
            result = Array.BinarySearch(bfm, k);
            if (result < 0)
            {
                k = k - 1;
            }
            else
            {
                Console.WriteLine(bfm[result]);
                break;
            }
        }
        //Array.BinarySearch(bfm,5);


    }
}


