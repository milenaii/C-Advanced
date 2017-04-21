using System;
namespace _5.ValueAndReferenceTypes
{
    class Program
    {
        static void Main()
        {
            // REFERENCE types - string, classes and interfaces, arrays
            //in stack is just reference for the adress in heap, their values are in heap

            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = arr1;

            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(string.Join(", ", arr2));
            
            // if we change one of the array - it will be change and anather array:
            // защото това са два разл адреса на един и същ масив

            arr2[2] = 10;

            Console.WriteLine(string.Join(", ", arr2));
            
            //VALUE types - almost all primitives types -
            // int,float, bool, DateTime and all structures

            int num1 = 5;
            int num2 = num1;

            num2 = 10;

            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
