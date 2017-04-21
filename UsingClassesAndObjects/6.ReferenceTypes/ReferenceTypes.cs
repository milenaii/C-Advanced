using System;
// Ако подадем масив или реф тип на метод, то след като метода действа върху масива
// вече масива ще е променен, няма да е първоначалния

// Ако си искаме и първоначалните данни - тр да клонираме - т.е. да създадем нова 
// масив със същите стойности
namespace _6.ReferenceTypes
{
    class ReferenceTypes
    {
        static void Main()
        {
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };
            int[] arr2 = arr1;

            // викаме метода 
            Some(arr2);

            Console.WriteLine(string.Join(", ", arr1));
            Console.WriteLine(string.Join(", ", arr2));

                
        }
        // метод
        static void Some(int[] arr)
        {
            arr[2] = 10;
        }

    }
}
